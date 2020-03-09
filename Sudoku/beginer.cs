using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication6
{
    public partial class beginer : Form
    {

        SqlConnection con;

        SqlCommand cmd;

        private string lvl = "beginer", nickname;

        private TextBox[,] matrix = new TextBox[9, 9];

        private SudokuClass b = new SudokuClass(9);

        private int sec = 0, mins = 0, yes_no = 0;

        public beginer(string s,int ok)
        {

            nickname = s;
            yes_no = ok;
            InitializeComponent();
            //con = new SqlConnection(global::WindowsFormsApplication6.Properties.Settings.Default.SudokuBaseConnectionString);
            //con.Open();

        }

        private void beginer_Load(object sender, EventArgs e)
        {

            Font font = new Font("Times New Roman", 28.0f);

            for (int i = 0; i < table.RowCount; i++)
            {
                for (int j = 0; j < table.ColumnCount; j++)
                {
                    matrix[i, j] = new TextBox();
                    matrix[i, j].Parent = table;
                    matrix[i, j].Location = new Point(i * 80, j * 80);
                    matrix[i, j].AutoSize = false;
                    matrix[i, j].Width = 80;
                    matrix[i, j].Height = 80;
                    matrix[i, j].Visible = true;
                    matrix[i, j].MaxLength = 1;
                    matrix[i, j].TextAlign = HorizontalAlignment.Center;
                    matrix[i, j].Font = font;
                    matrix[i, j].BackColor = Color.White; 
                    matrix[i, j].TextChanged += new EventHandler(matrix_TextChanged);
                    matrix[i, j].Click += new EventHandler(matrix_Click);
                }
            }
            AddNumbers();
            timer.Start();

        }

        private void AddNumbers()
        {

            int ok = 0;
            while (ok < 56)
            {
                var rnd1 = new Random(Guid.NewGuid().GetHashCode());
                var rnd2 = new Random(Guid.NewGuid().GetHashCode());
                int x1 = rnd1.Next(0, 9);
                int x2 = rnd2.Next(0, 9);
                if (matrix[x1, x2].Text == "")
                {
                    matrix[x1, x2].Text = b.numbers[x1, x2].ToString();
                    matrix[x1, x2].Enabled = false;
                    ok++;
                }
            }

        }

        private void table_Paint(object sender, PaintEventArgs e)
        {

            Pen blackPen = new Pen(Color.Black, 6);

            Rectangle rect = new Rectangle(0, 0, 450, 406);

            e.Graphics.DrawRectangle(blackPen, rect);

            e.Graphics.DrawLine(blackPen, 0F, 135F, 600F, 135F);
            e.Graphics.DrawLine(blackPen, 0F, 270F, 600F, 270F);

            e.Graphics.DrawLine(blackPen, 150F, 0F, 150F, 500F);
            e.Graphics.DrawLine(blackPen, 300F, 0F, 300F, 500F);

        }

        private void back_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void restart_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < table.RowCount; i++)
                for (int j = 0; j < table.ColumnCount; j++)
                {
                    matrix[i, j].Text = "";
                    matrix[i, j].Enabled = true;
                }
            for (int i = 0; i < table.ColumnCount; i++)
                for (int j = 0; j < table.ColumnCount; j++)
                    matrix[i, j].BackColor = Color.White;
            b = new SudokuClass(9);
            AddNumbers();
            timer.Stop();
            sec = 0;
            mins = 0;
            seconds.Text = "00";
            minutes.Text = "0";
            timer.Start();

        }

        private void timer_Tick(object sender, EventArgs e)
        {

            sec++;
            if (sec == 60)
            {
                mins++;
                minutes.Text = mins.ToString();
                seconds.Text = "00";
                sec = 0;
                if (mins == 10)
                {
                    timer.Stop();
                    MessageBox.Show("Time is up!");

                }

            }
            else
            {
                if (sec < 10)
                    seconds.Text = "0" + sec.ToString();
                else
                    seconds.Text = sec.ToString();

            }

        }

        private void verify(object sender, EventArgs e)
        {

            int ok = 1;
            for (int i = 0; i < table.RowCount; i++)
                for (int j = 0; j < table.ColumnCount; j++)
                    if (matrix[i, j].Text == "")
                        return;
                    else
                        if (matrix[i, j].Text != b.numbers[i, j].ToString())
                            ok = 0;
            if (ok == 1)
            {
                timer.Stop();
                MessageBox.Show("Congratulations! You won!");
                this.Hide();
                //if (yes_no == 0)
                //{
                //    cmd = new SqlCommand("SELECT * FROM board", con);
                //    SqlDataReader reader = cmd.ExecuteReader();
                //    List<string> l1 = new List<string>();
                //    while (reader.Read())
                //    {
                //        l1.Add(reader.GetString(1));
                //    }
                //    reader.Close();
                //    string b = @"INSERT INTO board(Id,Nickname,Mins,Sec,Date,Level) VALUES(" + l1.Count + ",'" + nickname + "','" + mins.ToString() + "','" + sec.ToString() + "',GETDATE(),'" + lvl + "')";
                //    reader.Close();
                //    cmd = new SqlCommand(b, con);
                //    cmd.ExecuteNonQuery();
                //}
                //else
                //{
                //    string b = @"UPDATE board SET Mins = '"+mins.ToString()+"',Sec = '"+sec+"', Date = GETDATE()";
                //    cmd = new SqlCommand(b, con);
                //    cmd.ExecuteNonQuery();
                //}
                //this.Hide();
                //show form = new show(lvl);
                //form.ShowDialog();
                restart_Click(sender, e);
            }
            else
                MessageBox.Show("Retry!");

        }

        private void matrix_TextChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < table.RowCount; i++)
                for (int j = 0; j < table.ColumnCount; j++)
                    if (matrix[i, j].Text != "" && "123456789".IndexOf(char.Parse(matrix[i, j].Text)) < 0)
                    {
                        MessageBox.Show("Please, enter just numbers from 1 to 9!");
                        matrix[i, j].Text = "";
                    }
            verify(sender, e);

        }

        private void matrix_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < table.ColumnCount; i++)
                for (int j = 0; j < table.ColumnCount; j++)
                    matrix[i, j].BackColor = Color.White;
            TextBox textClicked = (TextBox)sender;
            for (int i = 0; i < table.RowCount; i++)
                for (int j = 0; j < table.ColumnCount; j++)
                    if (matrix[i, j].Location == textClicked.Location)
                    {
                        for (int l = 0; l < table.ColumnCount; l++)
                            matrix[l, j].BackColor = Color.LightGray;
                        for (int k = 0; k < table.ColumnCount; k++)
                            matrix[i, k].BackColor = Color.LightGray;
                        for (int k = 0; k < 3; k++)
                            for (int l = 0; l < 3; l++)
                                matrix[i / 3 * 3 + k, j / 3 * 3 + l].BackColor = Color.LightGray;
                        break;
                    }

        }

    }
}
