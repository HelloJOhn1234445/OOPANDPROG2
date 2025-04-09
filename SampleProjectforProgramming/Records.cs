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

namespace SampleProjectforProgramming
{
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();
        }
        public void Display()
        {
            StudentInfo dbclass = new StudentInfo();
            recordviews.DataSource = dbclass.SelectCmd("SELECT * FROM tblRecord");

            // Adjusting column widths
            recordviews.Columns[0].Width = 50;
            recordviews.Columns[1].Width = 100;
            recordviews.Columns[2].Width = 300;
            recordviews.Columns[3].Width = 100;
            recordviews.Columns[4].Width = 200;
            recordviews.Columns[5].Width = 200;
            recordviews.Columns[6].Width = 100;
            recordviews.Columns[7].Width = 100;
        }

        private void Records_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\John Rhey Tamares\\source\\repos\\SampleProjectforProgramming\\SampleProjectforProgramming\\Student.mdf\";Integrated Security=True";

            string querytblStudent = "SELECT * FROM tblStudent";
            string querytblTime = "SELECT * FROM tblTime";

            // Assuming Table1 and Table2 have the following columns for demonstration:
            // Table1: Id, Name, Program
            // Table2: Id, Email, Address
            // DestinationTable: Id, Name, Program, Email, Address

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Fetch data from Table1
                    SqlDataAdapter adapter1 = new SqlDataAdapter(querytblStudent, connection);
                    DataTable dt1 = new DataTable();
                    adapter1.Fill(dt1);

                    // Fetch data from Table2
                    SqlDataAdapter adapter2 = new SqlDataAdapter(querytblTime, connection);
                    DataTable dt2 = new DataTable();
                    adapter2.Fill(dt2);

                    // Assuming both tables have an 'Id' column to join them
                    var combinedData = from row1 in dt1.AsEnumerable()
                                       join row2 in dt2.AsEnumerable() on row1.Field<int>("Student_Id") equals row2.Field<int>("Student_Id")
                                       select new
                                       {
                                           Student_Id = row1.Field<int>("Student_Id"),
                                           Student_Name = row1.Field<string>("Student_Name"),
                                           Program = row1.Field<string>("Program"),
                                           Email = row1.Field<string>("Email"),
                                           Address = row1.Field<string>("Address"),
                                           Contact = row1.Field<string>("Contact"),
                                           Date = row2.Field<DateTime>("Date"), // Use DateTime for Date field
                                           Time = TimeSpan.Parse(row2.Field<string>("Time")) // Convert string to TimeSpan for Time field
                                       };

                    // Insert combined data into DestinationTable
                    foreach (var item in combinedData)
                    {
                        string insertQuery = "INSERT INTO tblRecords (Student_Id, Student_Name, Program, Email, Address,Contact, Date, Time) VALUES (@Student_Id, @Student_Name, @Program, @Email,@Contact, @Address,@Date,@Time)";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@Student_Id", item.Student_Id);
                            cmd.Parameters.AddWithValue("@Student_Name", item.Student_Name);
                            cmd.Parameters.AddWithValue("@Program", item.Program);
                            cmd.Parameters.AddWithValue("@Email", item.Email);
                            cmd.Parameters.AddWithValue("@Address", item.Address);
                            cmd.Parameters.AddWithValue("@Contact", item.Contact);
                            cmd.Parameters.AddWithValue("@Date", item.Date);
                            cmd.Parameters.AddWithValue("@Time", item.Time);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    Display();
                    MessageBox.Show("Data combined and inserted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }

        }
    }
}
    

        
    
