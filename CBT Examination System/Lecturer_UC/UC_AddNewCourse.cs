using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBT_Examination_System.Lecturer_UC
{
    public partial class UC_AddNewCourse : UserControl
    {
        public int lecturerID;
        public string lecturerName;

        public UC_AddNewCourse()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string level = comboSelectLevel.SelectedItem.ToString();
            string department = comboSelectDepartment.SelectedItem.ToString();
            string courseCode = txtCourseCode.Text;
            string courseTitle = txtCourseTitle.Text;
            int units = int.Parse(comboUnits.SelectedItem.ToString());
            string timerValue = comboTimer.SelectedItem.ToString();

            // Create DatabaseManager object
            DatabaseManager dbManager = new DatabaseManager();

            // Define SQL query to insert a new row into the courses table
            string query = "INSERT INTO courses (Lecturer_ID, Lecturer_Name, Level, Department, Course_Code, Course_Title, Units, Exam_Timer) " +
                                    "VALUES (@lecturerID, @Lecturer_Name, @level, @department, @course_code, @course_title, @units, @timer_value)";

            // Define parameters for query
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@lecturerID", lecturerID);
            parameters.Add("@Lecturer_Name", lecturerName);
            parameters.Add("@level", level);
            parameters.Add("@department", department);
            parameters.Add("@course_code", courseCode);
            parameters.Add("@course_title", courseTitle);
            parameters.Add("@units", units);
            parameters.Add("@timer_value", timerValue);

            // Execute query to insert new row
            int rowsAffected = dbManager.UpdateData(query, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Course added successfully");
                ClearAll();
            }
            else
            {
                MessageBox.Show("Error adding courses");
            }
        }


        private void ClearAll()
        {
            txtCourseCode.Clear();
            txtCourseTitle.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved Data Will be Lost", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ClearAll();
            }
        }

        private void btnFinish_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Do You Want To Close This Window? \n Unsaved Data Will be Lost", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ClearAll();
                Hide();
            }
        }

    }
}
     