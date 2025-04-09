using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SampleProjectforProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\John Rhey Tamares\\source\\repos\\SampleProjectforProgramming\\SampleProjectforProgramming\\Student1.mdf\";Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            StudentInfo info = new StudentInfo();
            SqlCommand cmd = new SqlCommand();
            string query_total = " SELECT COUNT(*) FROM tblStudent";
            sqlConnection.Open();
            cmd = new SqlCommand(query_total, sqlConnection);
            Int32 fuc = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Dispose();
            sqlConnection.Close();
            lblRegistration.Text = "Total Number=" + fuc.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gaddStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNewStudent f1 = new FormNewStudent();
            f1.ShowDialog();
            f1 = null;
        }

        private void gtimeinout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Search f1 = new Search();
            f1.ShowDialog();
            f1 = null;
        }

        private void grecords_Click(object sender, EventArgs e)
        {
            this.Hide();
            Record2 f1 = new Record2();
            f1.ShowDialog();
            f1 = null;
        }

        private void gprint_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
           // label2.Text = LogIn.username;
        }

        private void lblRegistration_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
