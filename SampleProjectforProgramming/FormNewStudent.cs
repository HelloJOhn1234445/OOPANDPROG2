using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SampleProjectforProgramming
{
    public partial class FormNewStudent : Form
    {
        public FormNewStudent()
        {
            InitializeComponent();
        }

        

        // Clears the input fields
        public void Cleaners()
        {
            txtName.Clear();
            txtEmail.Clear();
            txtAddress.Clear(); // Clear the address field
            txtID.Clear(); // Clear the student ID field
            txtContact.Clear();
            cmbProgram.SelectedIndex = -1;
        }
        public void Display()
        {
            StudentInfo dbclass = new StudentInfo();
            // Select only the required columns
            dgview.DataSource = dbclass.SelectCmd("SELECT * FROM tblStudent");

            // Ensure all columns are visible
            foreach (DataGridViewColumn column in dgview.Columns)
            {
                column.Visible = true;
            }

            // Adjusting column widths for the visible columns
            dgview.Columns["Student_ID"].Width = 100;
            dgview.Columns["Student_Name"].Width = 200;
            dgview.Columns["Program"].Width = 300;
            dgview.Columns["Email"].Width = 300;
            dgview.Columns["Address"].Width = 300;
            dgview.Columns["Contact"].Width = 100;
        }

        // Displays the data from the database into the DataGridView
        /*public void Display()
        {
            StudentInfo dbclass = new StudentInfo();
            dgview.DataSource = dbclass.SelectCmd("SELECT * FROM tblStudent");

            // Set specific columns to be visible
            dgview.Columns["Column1"].Visible = true; // Replace "Column1" with actual column name
            dgview.Columns["Column2"].Visible = true; // Replace "Column2" with actual column name
            dgview.Columns["Column3"].Visible = true; // Replace "Column3" with actual column name


            // Hide the rest of the columns
            for (int i = 0; i < dgview.Columns.Count; i++)
            {
                if (dgview.Columns[i].Name != "Column1" &&
                    dgview.Columns[i].Name != "Column2" &&
                    dgview.Columns[i].Name != "Column3")
                {
                    dgview.Columns[i].Visible = false;
                }
            }

            // Adjusting column widths for the visible columns
            dgview.Columns["Column1"].Width = 100;
            dgview.Columns["Column2"].Width = 200;
            dgview.Columns["Column3"].Width = 300;
        }*/

     

        // Form load event handler
        private void FormNewStudent_Load(object sender, EventArgs e)
        {
            timer1.Start();

            

            txtID.Text = "Ex. MCC2023-00010";
            txtID.ForeColor = Color.Gray;
            txtName.Text = "First Name, Middle Name, Last Name";
            txtName.ForeColor = Color.Gray;
            txtContact.Text = "09**********";
            txtContact.ForeColor = Color.Gray;
            
            lblNameStat.ForeColor = Color.Bisque;
            lblContactStat.ForeColor = Color.Bisque;

            try
            {
                StudentInfo dbclass = new StudentInfo();
                Status.Text = "Database Status: Connected";
                Status.ForeColor = Color.Green;
                Display();
            }
            catch
            {
                Status.Text = "Database Status: Disconnected";
                Status.ForeColor = Color.Red;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string currentDate = DateTime.Now.ToShortDateString(); // Use ToShortDateString for shorter date format
            string currentTime = DateTime.Now.ToLongTimeString(); // Use ToLongTimeString for longer time format
            label5.Text = currentDate; // Display current date
            label6.Text = currentTime; // Display current time

        }

        // Save button click event handler
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblNameStat.ForeColor == Color.Red || lblContactStat.ForeColor == Color.Red)
                {
                    MessageBox.Show("There's an error in the input format.");
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(cmbProgram.Text))
                    {
                        MessageBox.Show("Required Fields");
                        txtName.Focus();
                    }
                    else
                    {
                        StudentInfo db = new StudentInfo();
                        // Formatting the date and time values
                        string currentDate = DateTime.Now.ToString("yyyy-MM-dd"); // Storing current date
                        string currentTime = DateTime.Now.ToString("HH:mm:ss"); // Storing current time

                        // Prepare the SQL query with properly formatted date and time
                        string sql = $"INSERT INTO tblStudent(Student_ID, Student_Name, Program, Email, Address, Contact) VALUES ('{txtID.Text}', '{txtName.Text}', '{cmbProgram.Text}', '{txtEmail.Text}', '{txtAddress.Text}','{txtContact.Text}')";
                        if (db.CUDcmd(sql) > 0)
                        {
                            Cleaners();
                            Display();
                            MessageBox.Show("Saved Successfully");
                        }
                        else
                        {
                            MessageBox.Show("An error has Occurred");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Saving an existing ID number. Please delete or update the existing record.","Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
               /* StudentInfo db = new StudentInfo();
                string sql = "DElETE FROM tblStudent WHERE Student_ID='"+txtID+"'";
                if (db.CUDcmd(sql) > 0)
                {
                    Cleaners();
                    Display();
                    MessageBox.Show("Saved Successfully");
                }
                else
                {
                    MessageBox.Show("An error has Occurred");
                }*/
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Confirmation", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                StudentInfo db = new StudentInfo();
                string sql = "Delete from tblStudent Where Student_ID= '" + txtID.Text + "'";

                if (db.CUDcmd(sql) > 0)
                {
                    Cleaners();
                    Display();
                    MessageBox.Show("Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("An Error has been Occured");
                }
         


            }

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Create an instance of the HomePage form
            Form1 homePage = new Form1();

            // Show the HomePage form
            homePage.Show();

            // Close the current form
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void button6_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            StudentInfo db = new StudentInfo();
            string sql = "UPDATE tblStudent SET  Student_Name='" + txtName.Text + "',Program='" + cmbProgram.Text + "',Email='" + txtEmail.Text + "',Address='" + txtAddress.Text + "',Contact='" + txtContact.Text + "'Where Student_ID='" + txtID.Text + "'";
            if (db.CUDcmd(sql) > 0)
            {
                Cleaners();
                Display();
                MessageBox.Show("Updated Successfully");
            }
            else
            {
                MessageBox.Show("An error has Occurred");
            }
        }

        private void dgview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.ForeColor = Color.Black;
            txtName.ForeColor = Color.Black;
            txtContact.ForeColor = Color.Black;
            lblNameStat.ForeColor = Color.Bisque;

            try
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRows = dgview.Rows[index];
                txtID.Text = selectedRows.Cells[0].Value.ToString();
                txtName.Text = selectedRows.Cells[1].Value.ToString();
                cmbProgram.Text = selectedRows.Cells[2].Value.ToString();
                txtEmail.Text = selectedRows.Cells[3].Value.ToString();
                txtAddress.Text = selectedRows.Cells[4].Value.ToString();
                txtContact.Text = selectedRows.Cells[5].Value.ToString();
            }
            catch
            {

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "Ex. MCC2023-00010")
            {
                txtID.Clear();
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == "")
            {
                txtID.Text= "Ex. MCC2023-00010";
                txtID.ForeColor = Color.Gray;
               
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "First Name, Middle Name, Last Name")
            {
                txtName.Clear();
                txtName.ForeColor = Color.Black;
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                txtName.Text = "First Name, Middle Name, Last Name";
                txtName.ForeColor = Color.Gray;
                lblNameStat.ForeColor= Color.Bisque;
            }
        }

        private void txtContact_Enter(object sender, EventArgs e)
        {
            if (txtContact.Text == "09**********")
            {
                txtContact.Clear();
                txtContact.ForeColor = Color.Black;
            }
        }

        private void txtContact_Leave(object sender, EventArgs e)
        {
            if (txtContact.Text.Trim() == "")
            {
                txtContact.Text= "09**********";
                txtContact.ForeColor = Color.Gray;
                lblContactStat.ForeColor= Color.Bisque;
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            char[] Namearray = txtName.Text.Trim().ToCharArray();
            foreach (var item in Namearray)
            {
                if (!char.IsLetter(item))
                {
                    lblNameStat.Text = "Name should not have numbers nor special characters";
                    lblNameStat.ForeColor = Color.Red;
                    
                    continue;
                }
                else
                {
                    lblNameStat.ForeColor = Color.Bisque;
                }
            }
        }

        private void txtContact_TextChanged(object sender, EventArgs e)
        {
            char[] Contactarray = txtContact.Text.ToCharArray();
            foreach (var item in Contactarray)
            {
                if (!char.IsDigit(item))
                {
                    lblContactStat.Text = "Contact should not have letters nor special characters";
                    lblContactStat.ForeColor = Color.Red;
                    
                }
                else
                {
                    lblContactStat.ForeColor = Color.Bisque;
                }
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbProgram_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblNameStat_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
