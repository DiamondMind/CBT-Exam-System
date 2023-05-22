using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBT_Examination_System.Student_UC
{
    public partial class uC_BeginExam : UserControl
    {
        DatabaseManager databaseManager = new DatabaseManager();
        ExamPage_UC uC_ExamPage;
        bool comboFilled;
        public string matricNo;
        string courseCode;

        public uC_BeginExam()
        {
            InitializeComponent();
        }

        private void BeginExam_Load(object sender, EventArgs e)
        {
            labelExamTime.Visible = false;

            // Find the instance of the ExamPage_UC user control on the parent form or its child controls
            uC_ExamPage = FindExamPageControl(this.Parent);

            if (uC_ExamPage == null)
            {
                labelExamTime.Text = "Error 404";
                labelExamTime.Visible = true;
            }
        }

        private ExamPage_UC FindExamPageControl(Control parentControl)
        {
            // Check if the parent control is null or if it is an ExamPage_UC control
            if (parentControl == null)
            {
                return null;
            }
            else if (parentControl is ExamPage_UC)
            {
                return (ExamPage_UC)parentControl;
            }

            // Recursively search for an ExamPage_UC control in the child controls
            foreach (Control childControl in parentControl.Controls)
            {
                ExamPage_UC examPageControl = FindExamPageControl(childControl);
                if (examPageControl != null)
                {
                    return examPageControl;
                }
            }

            return null;
        }

        public void FillCourseComboBox(string department, string level)
        {
            if (comboFilled)
                return;

            //string query = "SELECT Course FROM examQuestions WHERE Department = @department AND Level = @level";
            string query = "SELECT Course FROM examQuestions WHERE (Department = @department OR Department = 'All') AND Level = @level";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@department", department);
            parameters.Add("@level", level);

            List<Dictionary<string, object>> result = databaseManager.GetData(query, parameters);
            HashSet<string> courses = new HashSet<string>(); // use HashSet to avoid repetition

            foreach (Dictionary<string, object> row in result)
            {
                string course = row["Course"].ToString();
                if (!courses.Contains(course)) // add course only if not already added
                {
                    courses.Add(course);
                    comboSelectCourse.Items.Add(course);
                    comboFilled = true;
                }
            }
        }
        
        private void comboSelectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected course from the combo box
            courseCode = comboSelectCourse.SelectedItem.ToString();
            if (courseCode == null)
            {
                // No course selected, so do nothing
                return;
            }

            // Retrieve the Exam_Timer value for the selected course from the "courses" table
            string query = "SELECT Exam_Timer FROM courses WHERE Course_Code = @selectedCourse";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@selectedCourse", courseCode);
            List<Dictionary<string, object>> result = databaseManager.GetData(query, parameters);

            // Set the text of the "txtTime" textbox to the Exam_Timer value (if it exists)
            if (result.Count > 0)
            {
                string examTimer = result[0]["Exam_Timer"].ToString();
                labelExamTime.Text = examTimer;
                labelExamTime.Visible = true;
            }
            else
            {
                labelExamTime.Visible = false;
            }

           
                  
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (comboSelectCourse.SelectedItem == null)
                return;

            if(ResultExist())
            {
               // MessageBox.Show("You have already written an exam for this course");
                //return;
            }
            //else
            {
                uC_ExamPage.SetCourse(comboSelectCourse.SelectedItem.ToString());
                uC_ExamPage.Visible = true;
                uC_ExamPage.BringToFront();
            }
            
            StudentDashboard parentForm = this.FindForm() as StudentDashboard;
            if (parentForm != null)
            {
                parentForm.examStarted = true;
            }
            else
            {
                MessageBox.Show("Error 404");
            }

        }

        private bool ResultExist()
        {
            string query = "SELECT 1 FROM studentsResults WHERE Matric_No = @matricNo AND Course_Code = @courseCode";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@matricNo", matricNo);
            parameters.Add("@courseCode", courseCode);

            // Execute the query to get the count of matching rows
            int rowCount = databaseManager.GetData(query, parameters).Count;

            // Return true if at least one matching row exists, otherwise return false
            return rowCount > 0;
        }


        public void CustomClose() 
        {
            labelExamTime.ResetText();
            labelExamTime.Visible = false;
            comboSelectCourse.SelectedIndex = 0;
            this.Visible = false;
        }
    }
}
