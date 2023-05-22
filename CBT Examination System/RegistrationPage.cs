using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBT_Examination_System
{
    public partial class RegistrationPage : Form
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void RegistrationPage_Load(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;
            guna2Panel2.Visible = false;
        }

        private void txtSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSelectUser.SelectedIndex == 0)
            {
                guna2Panel2.Visible = true;
                guna2Panel2.BringToFront();
                guna2Panel1.Visible = false;
            }
            else if (txtSelectUser.SelectedIndex == 1)
            {
                guna2Panel1.Visible = true;
                guna2Panel1.BringToFront();
                guna2Panel2.Visible = false;
            }
        }

        private void checkBoxShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowHide.Checked == true)
            {
                txtPassword.PasswordChar = '\0';    // make password visible
                checkBoxShowHide.Text = "Hide Password";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                checkBoxShowHide.Text = "Show Password";
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Check if any required fields are empty
            if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) ||
                string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPhoneNo.Text) ||
                string.IsNullOrEmpty(txtUserName.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (txtPhoneNo.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Phone number cannot contain letters.");
                return;
            }

            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string phoneNo = txtPhoneNo.Text;
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            DatabaseManager dbManager = new DatabaseManager();

            string query = "SELECT MAX(Lecturer_ID) AS HighestLecturerID FROM lecturerLoginDetails";

            // Execute query to get the highest Lecturer_ID
            List<Dictionary<string, object>> result = dbManager.GetData(query);

            int lecturerID = 1; // Default value if no rows are returned
            if (result.Count > 0 && result[0]["HighestLecturerID"] != DBNull.Value)
            {
                lecturerID = Convert.ToInt32(result[0]["HighestLecturerID"]) + 1;
            }

            query = "INSERT INTO lecturerLoginDetails (Lecturer_ID, First_Name, Last_Name, Username, Password, Email, Phone_No) " +
                    "VALUES (@lecturerID, @firstName, @lastName, @username, @password, @email, @phoneNo)";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@lecturerID", lecturerID);
            parameters.Add("@firstName", firstName);
            parameters.Add("@lastName", lastName);
            parameters.Add("@username", username);
            parameters.Add("@password", password);
            parameters.Add("@email", email);
            parameters.Add("@phoneNo", phoneNo);

            int rowsAffected = dbManager.UpdateData(query, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Registration Completed, Moving to Login Page");

                LoginPage loginPage = new LoginPage();
                loginPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error registering lecturer");
            }
            
        }

        private void SbtnRegister_Click(object sender, EventArgs e)
        {
            // Check if any required fields are empty
            if (string.IsNullOrEmpty(StxtFullName.Text) || string.IsNullOrEmpty(StxtMatricNo.Text) ||
                string.IsNullOrEmpty(StxtEmail.Text) || string.IsNullOrEmpty(StxtPhoneNo.Text) ||
                string.IsNullOrEmpty(StxtSession.Text))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (StxtPhoneNo.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Phone number cannot contain letters.");
                return;
            }

            string fullName = StxtFullName.Text;
            string matricNo = StxtMatricNo.Text;
            string email = StxtEmail.Text;
            string phoneNo = StxtPhoneNo.Text;
            string session = StxtSession.Text;
            string dept = ScomboSelectDept.SelectedItem.ToString();
            string level = ScomboSelectLevel.SelectedItem.ToString();

            DatabaseManager dbManager = new DatabaseManager();

            string query = "INSERT INTO studentLoginDetails (Full_Name, Matric_No, Email, Phone_No, Session, Department, Level) " +
                           "VALUES (@fullName, @matricNo, @email, @phoneNo, @session, @department, @level)";

            // Define parameters for query
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@fullName", fullName);
            parameters.Add("@matricNo", matricNo);
            parameters.Add("@email", email);
            parameters.Add("@phoneNo", phoneNo);
            parameters.Add("@session", session);
            parameters.Add("@department", dept);
            parameters.Add("@level", level);

            // Execute query to insert new row
            int rowsAffected = dbManager.UpdateData(query, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Registration Completed, Moving to Login Page");

                LoginPage loginPage = new LoginPage();
                loginPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error registering student");
            }
        }
    }
}
