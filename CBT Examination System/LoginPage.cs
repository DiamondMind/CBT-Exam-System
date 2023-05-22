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
    public partial class LoginPage : Form
    {
        DatabaseManager dbManager = new DatabaseManager();

        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            guna2Panel1.Visible = false;
            guna2Panel2.Visible = false;

            wrongLabel.Visible = false;
            wrongLabel2.Visible = false;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@username", username);
            parameters.Add("@password", password);

            string query = "SELECT * FROM lecturerLoginDetails WHERE Username = @username AND Password = @password";
            List<Dictionary<string, object>> result = dbManager.GetData(query, parameters);

            if (result.Count > 0)
            {
                MessageBox.Show("Authentication Complete. Moving To Your Dashboard");

                wrongLabel.Visible = false;

                // assign the value of Lecturer_ID to the label
                LecturerDashboard _lecturer = new LecturerDashboard();
                _lecturer.userID = result[0]["Lecturer_ID"].ToString();         
                _lecturer.userName = result[0]["Last_Name"].ToString() + " " + result[0]["First_Name"].ToString();


                _lecturer.Show();
                this.Hide();
            }
            else
            {
                wrongLabel.Visible = true;
            }
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            string matricNo = txtMatricNo.Text;

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@matricNo", matricNo);

            string query = "SELECT * FROM studentLoginDetails WHERE Matric_No = @matricNo";

            List<Dictionary<string, object>> result = dbManager.GetData(query, parameters);

            if (result.Count > 0)
            {
                MessageBox.Show("Authentication Complete. Moving To Your Dashboard");

                wrongLabel2.Visible = false;

                StudentDashboard _student = new StudentDashboard();
                _student.matricNo = result[0]["Matric_No"].ToString();
                _student.fullName = result[0]["Full_Name"].ToString();
                _student.level = result[0]["Level"].ToString();
                _student.dept = result[0]["Department"].ToString();
                _student.session = result[0]["Session"].ToString();

                _student.Show();
                this.Hide();
            }
            else
            {
                wrongLabel2.Visible = true;
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationPage _registrationPage = new RegistrationPage();
            _registrationPage.Show();
            this.Hide();
        }

        private void btnStudentRegistration_Click(object sender, EventArgs e)
        {
            RegistrationPage _registrationPage = new RegistrationPage();
            _registrationPage.Show();
            this.Hide();
        }
    }
}
