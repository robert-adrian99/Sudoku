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
    public partial class show : Form
    {

        SqlConnection con;

        SqlCommand cmd;
        
        SqlDataAdapter da;
        
        DataTable dt = new DataTable();
        
        private string lvl;

        public show(string lev)
        {

            lvl = lev;
            InitializeComponent();
            con = new SqlConnection(global::WindowsFormsApplication6.Properties.Settings.Default.SudokuBaseConnectionString);
            con.Open();

        }

        void afisare(string s)
        {

            cmd = new SqlCommand(s, con);
            cmd.ExecuteNonQuery();
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridShow.DataSource = dt;

        }

        private void show_Load(object sender, EventArgs e)
        {

            afisare(@"SELECT TOP(10)* FROM board WHERE Level='" + lvl + "' ORDER BY Mins, Sec");

        }

        private void exit_Click(object sender, EventArgs e)
        {

            this.Close();

        }

    }
}
