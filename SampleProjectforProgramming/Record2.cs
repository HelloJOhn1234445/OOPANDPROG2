using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SampleProjectforProgramming
{
    public partial class Record2 : Form
    {
        public Record2()
        {
            InitializeComponent();
        }
        private void Display( string sql)
        {
            StudentInfo dbclass = new StudentInfo();
            dataGridView1.DataSource = dbclass.SelectCmd(sql);

            // Adjusting column widths
            dataGridView1.Columns[0].Width = 100;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 300;
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;

            label2.Text = "Records: "+(dataGridView1.Rows.Count-1).ToString();
        }
        private void Record2_Load(object sender, EventArgs e)
        {
            Display("Select * from tblTime");
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\John Rhey Tamares\source\repos\SampleProjectforProgramming\SampleProjectforProgramming\DbStudent.mdf"";Integrated Security=True";

            try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                    string query = "SELECT *  FROM tblTime";
                                       

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                dataGridView1.DataSource = dt;
                                dataGridView1.Columns["Id"].HeaderText = "Id";
                                dataGridView1.Columns["Student_ID"].HeaderText = "Student_ID";
                                dataGridView1.Columns["Student_Name"].HeaderText = "Student_Name";
                                dataGridView1.Columns["Program"].HeaderText = "Program";
                                dataGridView1.Columns["Date"].HeaderText = "Date";
                                dataGridView1.Columns["Time_In"].HeaderText = "Time_In";
                                dataGridView1.Columns["Time_Out"].HeaderText = "Time_Out";
                            }
                            else
                            {
                                MessageBox.Show("No records found.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {//For Search
            string sql = "";
            if (cboSearch.SelectedIndex == 0)
                sql = "Select * From tblTime Where Id like '" + txtSearch.Text + "%'";
            else if (cboSearch.SelectedIndex == 1)
                sql = "Select * From tblTime Where Student_ID like '" + txtSearch.Text + "%'";
            else if (cboSearch.SelectedIndex == 2)
                sql = "Select * From tblTime Where Student_Name like '" + txtSearch.Text + "%'";
            else if (cboSearch.SelectedIndex == 3)
                sql = "Select * From tblTime Where Program like '" + txtSearch.Text + "%'";
            else if (cboSearch.SelectedIndex == 4)
                sql = "Select * From tblTime Where Date like '" + txtSearch.Text + "%'";
            else if (cboSearch.SelectedIndex == 5)
                sql = "Select * From tblTime Where Time_In like '" + txtSearch.Text + "%'";        
            else if (cboSearch.SelectedIndex == 6)
                sql = "Select * From tblTime Where Time_Out like '" + txtSearch.Text + "%'";
            else sql = "Select * from tblTime";
            Display(sql);


        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboSearch.SelectedIndex > 0)
                txtSearch.Enabled = true;
            else txtSearch.Enabled = false;
        }  

        private void label5_Click(object sender, EventArgs e)
        {

        }

     
        private void gaddStudent_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormNewStudent f1 = new FormNewStudent();
            f1.ShowDialog();
            f1 = null;
        }

        private void gtimeinout_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Search f1 = new Search();
            f1.ShowDialog();
            f1 = null;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
