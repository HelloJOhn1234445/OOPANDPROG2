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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SampleProjectforProgramming
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        /*private void Display(string sql)
        {
            StudentInfo dbclass = new StudentInfo();
            dGridview.DataSource = dbclass.SelectCmd(sql);

            // Adjusting column widths
            dGridview.Columns[0].Width = 100;
            dGridview.Columns[1].Width = 200;
            dGridview.Columns[2].Width = 300;
            dGridview.Columns[3].Width = 100;
            dGridview.Columns[4].Width = 100;
            dGridview.Columns[5].Width = 100;
        }*/
            private void Search_Load(object sender, EventArgs e)
            {
                timer1.Start();
                try
                {
               // Display("Select * from tblTime");
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\John Rhey Tamares\source\repos\SampleProjectforProgramming\SampleProjectforProgramming\DbStudent.mdf"";Integrated Security=True";
                //

                StudentInfo dbclass = new StudentInfo();
                    Status.Text = "Database Status: Connected";
                    Status.ForeColor = Color.Green;
                    
                }
                catch
                {
                    Status.Text = "Database Status: Disconnected";
                    Status.ForeColor = Color.Red;
                }
            }

            private bool StudentIdExists(string studentId)
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\John Rhey Tamares\\source\\repos\\SampleProjectforProgramming\\SampleProjectforProgramming\\DbStudent.mdf\";Integrated Security=True";
                string sql = "SELECT COUNT(*) FROM tblStudent WHERE Student_ID = @Student_ID";
                int count = 0;

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@Student_ID", studentId);
                        count = (int)cmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }

                return count > 0;
            }

            private void id_TextChanged(object sender, EventArgs e)
            {
                if (!string.IsNullOrWhiteSpace(id.Text))
                {
                    StudentInfo db = new StudentInfo();
                    DataTable dt = db.SelectCmd("SELECT * FROM tblStudent WHERE Student_ID = @Student_ID", new SqlParameter("@Student_ID", id.Text));
                    if (dt.Rows.Count > 0)
                    {
                        txtName.Text = dt.Rows[0]["Student_Name"].ToString();
                        txtProgram.Text = dt.Rows[0]["Program"].ToString();
                    }
                    else
                    {
                        txtName.Clear();
                        txtProgram.Clear();
                    }
                }
                else
                {
                    txtName.Clear();
                    txtProgram.Clear();
                    MessageBox.Show("No record found.");
                }
            }

            private void timer1_Tick_1(object sender, EventArgs e)
            {
                textBox7.Text = DateTime.Now.ToShortDateString();
                textBox6.Text = DateTime.Now.ToLongTimeString();
            }

            private void id_KeyDown(object sender, KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (!string.IsNullOrWhiteSpace(id.Text))
                    {
                        if (StudentIdExists(id.Text))
                        {
                            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                            string currentTime = DateTime.Now.ToString("HH:mm:ss");

                            if (UserAlreadyTimedIn(id.Text, currentDate))
                            {
                                RecordTimeOut(id.Text, currentDate, currentTime);
                            }
                            else
                            {
                                RecordTimeIn(id.Text, currentDate, currentTime);
                            }

                            e.SuppressKeyPress = true;
                        }
                        else
                        {
                            MessageBox.Show("Student ID not found in the database.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please provide the student ID.");
                    }
                }
            }

            private bool UserAlreadyTimedIn(string studentId, string currentDate)
            {
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\John Rhey Tamares\\source\\repos\\SampleProjectforProgramming\\SampleProjectforProgramming\\DbStudent.mdf\";Integrated Security=True";
                string sql = "SELECT COUNT(*) FROM tblTime WHERE Student_ID = @Student_ID AND Date = @Date AND Time_Out IS NULL";
                int count = 0;

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@Student_ID", studentId);
                        cmd.Parameters.AddWithValue("@Date", currentDate);
                        count = (int)cmd.ExecuteScalar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }

                return count > 0;
            }

        private void RecordTimeIn(string studentId, string currentDate, string currentTime)
        {
            if (!UserAlreadyTimedIn(studentId, currentDate))
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\John Rhey Tamares\source\repos\SampleProjectforProgramming\SampleProjectforProgramming\DbStudent.mdf"";Integrated Security=True";
                string selectSql = "SELECT * FROM tblTime WHERE Student_ID = @Student_ID AND Date = @Date AND Time_Out IS NULL";
                string updateSql = "UPDATE tblTime SET Time_In = @Time_In WHERE Student_ID = @Student_ID AND Date = @Date AND Time_Out IS NULL";
                string sql = "INSERT INTO tblTime (Student_ID, Student_Name,Program, Date, Time_In) VALUES (@Student_ID, @Student_Name,@Program,@Date, @Time_In)";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(selectSql, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@Student_ID", studentId);
                        cmd.Parameters.AddWithValue("@Student_Name", txtName.Text);
                       
                        cmd.Parameters.AddWithValue("@Date", currentDate);
                        cmd.Parameters.AddWithValue("@Time_In", currentTime);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Close();
                            using (SqlCommand updateCmd = new SqlCommand(updateSql, conn))
                            {
                                updateCmd.Parameters.AddWithValue("@Student_ID", studentId);
                                updateCmd.Parameters.AddWithValue("@Date", currentDate);
                                updateCmd.Parameters.AddWithValue("@Time_In", currentTime);
                                updateCmd.ExecuteNonQuery();
                                MessageBox.Show("Time in recorded successfully.");
                            }
                        }
                        else
                        {
                            reader.Close();
                            using (SqlCommand insertCmd = new SqlCommand(sql, conn))
                            {
                                insertCmd.Parameters.AddWithValue("@Student_ID", studentId);
                                insertCmd.Parameters.AddWithValue("@Student_Name", txtName.Text);
                                insertCmd.Parameters.AddWithValue("@Program", txtProgram.Text);
                                insertCmd.Parameters.AddWithValue("@Date", currentDate);
                                insertCmd.Parameters.AddWithValue("@Time_In", currentTime);
                                insertCmd.ExecuteNonQuery();
                                MessageBox.Show("Time in recorded successfully.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }

            }
            else
            {
                MessageBox.Show("Already timed in for today");
            }
        }

            private void RecordTimeOut(string studentId, string currentDate, string currentTime)
            {
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\John Rhey Tamares\source\repos\SampleProjectforProgramming\SampleProjectforProgramming\DbStudent.mdf"";Integrated Security=True";
            string sql = "UPDATE tblTime SET Time_Out = @Time_Out WHERE Student_ID = @Student_ID AND Date = @Date AND Time_Out IS NULL";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@Time_Out", currentTime);
                        cmd.Parameters.AddWithValue("@Student_ID", studentId);
                        cmd.Parameters.AddWithValue("@Date", currentDate);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Time out recorded successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to record time out. No matching record found.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error recording time out: {ex.Message}");
                }
            }

            private void pictureBox1_Click(object sender, EventArgs e)
            {
                Form1 homePage = new Form1();
                homePage.Show();
                this.Close();
            }

            private void button5_Click(object sender, EventArgs e)
            {
                LogIn logIn = new LogIn();
                logIn.Show();
                this.Hide();
            }

            private void gaddStudent_Click(object sender, EventArgs e)
            {
                FormNewStudent homePage = new FormNewStudent();
                homePage.Show();
                this.Close();
            }

            private void grecords_Click(object sender, EventArgs e)
            {
                Record2 homePage = new Record2();
                homePage.Show();
                this.Close();
            }

            private void pictureBox2_Click(object sender, EventArgs e)
            {

            }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

    /*private void Search_Load(object sender, EventArgs e)
        {
            timer1.Start();
            try
            {
                StudentInfo dbclass = new StudentInfo();
                Status.Text = "Database Status: Connected";
                Status.ForeColor = Color.Green;
            }
            catch
            {
                Status.Text = "Database Status: Disconnected";
                Status.ForeColor = Color.Red;
            }
        }
        private bool StudentIdExists(string studentId)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\John Rhey Tamares\\source\\repos\\SampleProjectforProgramming\\SampleProjectforProgramming\\Student2.mdf\";Integrated Security=True";
            string sql = "SELECT COUNT(*) FROM tblStudent WHERE Student_ID = @Student_ID";
            int count = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Student_ID", studentId);
                    count = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return count > 0;
        }


        private void id_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(id.Text))
            {
                StudentInfo db = new StudentInfo();
                DataTable dt = db.SelectCmd("SELECT * FROM tblStudent WHERE Student_ID = @Student_ID", new SqlParameter("@Student_ID", id.Text));
                if (dt.Rows.Count > 0)
                {
                    txtName.Text = dt.Rows[0]["Student_Name"].ToString();
                    txtProgram.Text = dt.Rows[0]["Program"].ToString();
                }
                else
                {
                    txtName.Clear();
                    txtProgram.Clear();
                }
            }
            else
            {
                    txtName.Clear();
                    txtProgram.Clear();
                    MessageBox.Show("No record found.");
            }
   
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            textBox7.Text = DateTime.Now.ToShortDateString();
            textBox6.Text = DateTime.Now.ToLongTimeString();
        }

        private void id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(id.Text))
                {
                    if (StudentIdExists(id.Text))
                    {
                        string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
                        string currentTime = DateTime.Now.ToString("HH:mm:ss");

                        if (UserAlreadyTimedIn( currentDate))
                        {
                            RecordTimeOut(currentDate, currentTime);
                        }
                        else
                        {
                            RecordTimeIn( currentDate, currentTime);
                        }

                        e.SuppressKeyPress = true;
                    }
                    else
                    {
                        MessageBox.Show("Student ID not found in the database.");
                    }
                }
                else
                {
                    MessageBox.Show("Please provide the student ID.");
                }
            }
        }


        private bool UserAlreadyTimedIn( string currentDate)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\John Rhey Tamares\\source\\repos\\SampleProjectforProgramming\\SampleProjectforProgramming\\Student2.mdf\";Integrated Security=True";
            string sql = "SELECT COUNT(*) FROM tblStudent WHERE  Date = @Date  AND Time_Out is Null";
            int count = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Date", currentDate);
                    count = (int)cmd.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            return count > 0;
        }

        private void RecordTimeIn( string currentDate, string currentTime)
        {
            if (UserAlreadyTimedIn(currentDate))
            {
                // Update the record with Time_Out
                RecordTimeOut(currentDate, currentTime);
            }
            else
            {
                // Insert a new record with Time_In
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\John Rhey Tamares\\source\\repos\\SampleProjectforProgramming\\SampleProjectforProgramming\\Student2.mdf\";Integrated Security=True";
                string sql = "INSERT INTO tblStudent (Date, Time_In) VALUES (@Date, @Time_In)";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                   
                        cmd.Parameters.AddWithValue("@Date", currentDate);
                        cmd.Parameters.AddWithValue("@Time_In", currentTime);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Time in recorded successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to record time in.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void RecordTimeOut(string currentDate, string currentTime)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\John Rhey Tamares\\source\\repos\\SampleProjectforProgramming\\SampleProjectforProgramming\\Student2.mdf\";Integrated Security=True";
            string sql = "UPDATE tblStudent SET Time_Out = @Time_Out WHERE  Date = @Date";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Time_Out", currentTime);
                    cmd.Parameters.AddWithValue("@Date", currentDate);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Time out recorded successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to record time out. No matching record found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error recording time out: {ex.Message}");
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 homePage = new Form1();
            homePage.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gaddStudent_Click(object sender, EventArgs e)
        {
            FormNewStudent homePage = new FormNewStudent();
            homePage.Show();
            this.Close();
        }

        private void grecords_Click(object sender, EventArgs e)
        {
            Record2 homePage = new Record2();
            homePage.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }

}*/
