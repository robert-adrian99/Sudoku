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
    public partial class Main : Form
    {

        SqlConnection con;

        SqlCommand cmd;

        int nr = 0;

        public Main()
        {

            InitializeComponent();
            //con = new SqlConnection(global::WindowsFormsApplication6.Properties.Settings.Default.SudokuBaseConnectionString);
            //con.Open();

        }

        private void learn_Click(object sender, EventArgs e)
        {

            if (nickname.Text != "")
            {
                //cmd = new SqlCommand(@"SELECT * FROM board WHERE Nickname = '" + nickname.Text + "' AND Level = 'learn'", con);
                //SqlDataReader read = cmd.ExecuteReader();
                //while (read.Read())
                //{
                //    nr++;
                //}
                //read.Close();
                if (nr != 0)
                {
                    DialogResult result = MessageBox.Show("Do you want to update the highscore? Your highscore will be updated if you achieve the curent highscore!", "This nickname is already taken!", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        this.Hide();
                        learn form = new learn(nickname.Text, 1);
                        form.ShowDialog();
                        this.Show();
                        nickname.Text = "";
                    }
                    if (result == DialogResult.No)
                    {
                        nickname.Text = "";
                    }
                    nr = 0;
                }
                else
                {
                    this.Hide();
                    learn form = new learn(nickname.Text, 0);
                    form.ShowDialog();
                    this.Show();
                    nickname.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Insert a nickname!");
            }

        }

        private void beginer_Click(object sender, EventArgs e)
        {

            if (nickname.Text != "")
            {
                //cmd = new SqlCommand(@"SELECT * FROM board WHERE Nickname = '" + nickname.Text + "' AND Level = 'beginer'", con);
                //SqlDataReader read = cmd.ExecuteReader();
                //while (read.Read())
                //{
                //    nr++;
                //}
                //read.Close();
                if (nr != 0)
                {
                    DialogResult result = MessageBox.Show("Do you want to update the highscore? Your highscore will be updated if you achieve the curent highscore!", "This nickname is already taken!", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        this.Hide();
                        beginer form = new beginer(nickname.Text, 1);
                        form.ShowDialog();
                        this.Show();
                        nickname.Text = "";
                    }
                    if (result == DialogResult.No)
                    {
                        nickname.Text = "";
                    }
                    nr = 0;
                }
                else
                {
                    this.Hide();
                    beginer form = new beginer(nickname.Text, 0);
                    form.ShowDialog();
                    this.Show();
                    nickname.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Insert a nickname!");
            }

        }

        private void intermediate_Click(object sender, EventArgs e)
        {

            if (nickname.Text != "")
            {
                //cmd = new SqlCommand(@"SELECT * FROM board WHERE Nickname = '" + nickname.Text + "' AND Level = 'intermediate'", con);
                //SqlDataReader read = cmd.ExecuteReader();
                //while (read.Read())
                //{
                //    nr++;
                //}
                //read.Close();
                if (nr != 0)
                {
                    DialogResult result = MessageBox.Show("Do you want to update the highscore? Your highscore will be updated if you achieve the curent highscore!", "This nickname is already taken!", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        this.Hide();
                        intermediate form = new intermediate(nickname.Text, 1);
                        form.ShowDialog();
                        this.Show();
                        nickname.Text = "";
                    }
                    if (result == DialogResult.No)
                    {
                        nickname.Text = "";
                    }
                    nr = 0;
                }
                else
                {
                    this.Hide();
                    intermediate form = new intermediate(nickname.Text, 0);
                    form.ShowDialog();
                    this.Show();
                    nickname.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Insert a nickname!");
            }

        }

        private void advanced_Click(object sender, EventArgs e)
        {

            if (nickname.Text != "")
            {
                //cmd = new SqlCommand(@"SELECT * FROM board WHERE Nickname = '" + nickname.Text + "' AND Level = 'advanced'", con);
                //SqlDataReader read = cmd.ExecuteReader();
                //while (read.Read())
                //{
                //    nr++;
                //}
                //read.Close();
                if (nr != 0)
                {
                    DialogResult result = MessageBox.Show("Do you want to update the highscore? Your highscore will be updated if you achieve the curent highscore!", "This nickname is already taken!", MessageBoxButtons.YesNoCancel);
                    if (result == DialogResult.Yes)
                    {
                        this.Hide();
                        advanced form = new advanced(nickname.Text, 1);
                        form.ShowDialog();
                        this.Show();
                        nickname.Text = "";
                    }
                    if (result == DialogResult.No)
                    {
                        nickname.Text = "";
                    }
                    nr = 0;
                }
                else
                {
                    this.Hide();
                    advanced form = new advanced(nickname.Text, 0);
                    form.ShowDialog();
                    this.Show();
                    nickname.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Insert a nickname!");
            }

        }


    }
}
