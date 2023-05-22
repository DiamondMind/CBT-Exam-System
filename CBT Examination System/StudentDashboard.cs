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
    public partial class StudentDashboard : Form
    {
        public string matricNo;
        public string fullName;
        public string level;
        public string dept;
        public string session;
        public bool examStarted;

        public StudentDashboard()
        {
            InitializeComponent();
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            labelMatricNo.Text = matricNo;
            labelName.Text = fullName;
            uC_ViewProfile.Visible = false;
            uC_ViewStudentCourses.Visible = false;
            uC_BeginExam.Visible = false;
            uC_ExamPage.Visible = false;
            uC_ViewResults.Visible = false;
            
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            uC_ViewProfile.FillProfileDetails(matricNo);
            uC_ViewProfile.Visible = true;
            uC_ViewProfile.BringToFront();
        }

        private void btnCloseAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to colse all tabs, Unsaved data will be lost", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                uC_BeginExam.Visible = false;
                uC_ExamPage.Visible = false;
                uC_ViewProfile.Visible = false;
                uC_ViewStudentCourses.Visible = false;
                uC_ViewResults.Visible = false;
            }
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

        private void btnViewCourses_Click(object sender, EventArgs e)
        {
            uC_ViewStudentCourses.Visible = true;
            uC_ViewStudentCourses.ConstructTable(level, dept);
            uC_ViewStudentCourses.BringToFront();
        }

        private void btnTakeExam_Click(object sender, EventArgs e)
        {

            if(examStarted == false)
            {
                uC_BeginExam.Visible = true;
                uC_BeginExam.FillCourseComboBox(dept, level);
                uC_BeginExam.matricNo = matricNo;
                uC_BeginExam.BringToFront();
            }
            else
            {
                uC_ExamPage.Visible = true;
                uC_ExamPage.BringToFront();
            }
            
        }

        private void btnViewResults_Click(object sender, EventArgs e)
        {
            uC_ViewResults.Visible = true;
            uC_ViewResults.ConstructTable(fullName, matricNo);
            uC_ViewResults.BringToFront();
        }
    }
}
