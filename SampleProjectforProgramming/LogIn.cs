using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SampleProjectforProgramming
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();

        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (ValidateUser(username, password))
            {
                MessageBox.Show("Welcome Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                username = txtUsername.Text;
                FormNewStudent f1 = new FormNewStudent();
                f1.ShowDialog();
                f1 = null;
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private bool ValidateUser(string username, string password)
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\John Rhey Tamares\\source\\repos\\SampleProjectforProgramming\\SampleProjectforProgramming\\LogIn.mdf\";Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(1) FROM tblLogIn WHERE admin = @admin AND password = @password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@admin", username);
                        command.Parameters.AddWithValue("@password", password);

                        connection.Open();
                        int result = (int)command.ExecuteScalar();
                        return result > 0;
                    }
                }
            }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = guna2CheckBox1.Checked ? '\0' : '*';
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
          
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

