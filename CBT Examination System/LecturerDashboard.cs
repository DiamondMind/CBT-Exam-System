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
    public partial class LecturerDashboard : Form
    {
        public string userID;
        public string userName;

        public LecturerDashboard()
        {
            InitializeComponent();
        }

        private void LecturerDashboard_Load(object sender, EventArgs e)
        {
            labelLecturerID.Text = userID;
            labelName.Text = userName;
            uC_AddNewCourse.Visible = false;
            uC_SetQuestions.Visible = false;
            uC_ViewCourses.Visible = false;
            uC_ViewQuestions.Visible = false;
            uC_ViewStudentsResults.Visible = false;

        }

        private void btnCloseAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to colse all tabs, Unsaved data will be lost", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                uC_AddNewCourse.Visible = false;
                uC_SetQuestions.Visible = false;
                uC_ViewCourses.Visible = false;
                uC_ViewQuestions.Visible = false;
                uC_ViewStudentsResults.Visible = false;
            }
        }

        private void btnAddNewCourse_Click(object sender, EventArgs e)
        {
            uC_AddNewCourse.Visible = true;
            uC_AddNewCourse.BringToFront();
            uC_AddNewCourse.lecturerID = int.Parse(userID);
            uC_AddNewCourse.lecturerName = labelName.Text;
        }

        private void btnViewDeleteCourses_Click(object sender, EventArgs e)
        {
            uC_ViewCourses.Visible = true;
            uC_ViewCourses.ConstructTable(userID);
            uC_ViewCourses.BringToFront();
        }

        private void btnSetQuestions_Click(object sender, EventArgs e)
        {
            uC_SetQuestions.Visible = true;
            uC_SetQuestions.SetParameters();
            uC_SetQuestions.BringToFront();
        }

        private void btnViewDeleteQuestions_Click(object sender, EventArgs e)
        {
            uC_ViewQuestions.Visible = true;
            uC_ViewQuestions.ConstructTable(userID);
            uC_ViewQuestions.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to logout, Unsaved data will be lost", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                LoginPage _loginPage = new LoginPage();
                _loginPage.Show();
                this.Hide();
            }
        }

        private void btnViewResults_Click(object sender, EventArgs e)
        {
            uC_ViewStudentsResults.Visible = true;
            uC_ViewStudentsResults.ConstructTable(userName);
            uC_ViewStudentsResults.BringToFront();
        }
    }
}
