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
    public partial class UC_SetQuestions : UserControl
    {
        int questionNo;
        int lecturerID;
        DatabaseManager dbManager = new DatabaseManager();

        public UC_SetQuestions()
        {
            InitializeComponent();
        }

        public void SetParameters()
        {
            GetLecturerID();
            comboSelectCourse.Items.Clear();
            comboSelectDept.Items.Clear();

            questionLabel.Visible = false;

            List<Dictionary<string, object>> courses = dbManager.GetData("SELECT Department, Course_Code FROM courses WHERE Lecturer_ID = @lecturerID", new Dictionary<string, object> { { "@lecturerID", lecturerID } });

            // Check if the query returned any results
            if (courses.Count == 0)
            {
                MessageBox.Show("No courses found. \n To set questions, you need to register courses first. ");
                return;
            }

            // Add the data to the comboboxes while removing duplicates
            HashSet<string> uniqueColumnBValues = new HashSet<string>();
            HashSet<string> uniqueColumnCValues = new HashSet<string>();

            foreach (Dictionary<string, object> course in courses)
            {
                string columnCValue = course["Department"].ToString();
                string columnBValue = course["Course_Code"].ToString();

                if (!uniqueColumnBValues.Contains(columnBValue))
                {
                    comboSelectCourse.Items.Add(columnBValue);
                    uniqueColumnBValues.Add(columnBValue);
                }

                if (!uniqueColumnCValues.Contains(columnCValue))
                {
                    comboSelectDept.Items.Add(columnCValue);
                    uniqueColumnCValues.Add(columnCValue);
                }
            }

            // Check if the comboboxes were populated
            if (comboSelectCourse.Items.Count == 0 || comboSelectDept.Items.Count == 0)
            {
                MessageBox.Show("Error: Unable to populate course and department list");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string department = comboSelectDept.SelectedItem.ToString();
            string course = comboSelectCourse.SelectedItem.ToString();
            string level = GetLevelForCourse(course);

            string qNo = questionLabel.Text;
            string question = txtQuestion.Text;

            string optionA = txtOptionA.Text;
            string optionB = txtOptionB.Text;
            string optionC = txtOptionC.Text;
            string optionD = txtOptionD.Text;

            string answer = comboSelectAnswer.SelectedItem.ToString();

            // Define SQL query to insert a new row into the courses table
            string query = "INSERT INTO examQuestions (Lecturer_ID, Level, Department, Course, Question_No, Question, OptionA, OptionB, OptionC, OptionD, Answer) " +
                                              "VALUES (@lecturer_ID, @level, @department, @course, @question_No, @question, @optionA, @optionB, @optionC, @optionD, @answer)";

            // Define parameters for query
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@lecturer_ID", lecturerID);
            parameters.Add("@level", level);
            parameters.Add("@department", department);
            parameters.Add("@course", course);
            parameters.Add("@question_No", int.Parse(qNo));
            parameters.Add("@question", question);
            parameters.Add("@optionA", optionA);
            parameters.Add("@optionB", optionB);
            parameters.Add("@optionC", optionC);
            parameters.Add("@optionD", optionD);
            parameters.Add("@answer", answer);

            // Execute query to insert new row
            int rowsAffected = dbManager.UpdateData(query, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Question added successfully");
                ClearAll();
                IncrementQuestionNumber();
            }
            else
            {
                MessageBox.Show("Error adding Questions");
            }

        }

        public string GetLevelForCourse(string courseCode)
        {
            string query = "SELECT Level FROM courses WHERE Course_Code = @courseCode";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@courseCode", courseCode);

            List<Dictionary<string, object>> data = dbManager.GetData(query, parameters);

            if (data.Count > 0)
            {
                // Retrieve the value from the first row's "Level" column
                if (data[0].TryGetValue("Level", out object level))
                {
                    return level.ToString();
                }
            }

            return string.Empty; // Return an empty string if the course is not found or the "Level" column value is null
        }


        public void ClearAll()
        {
            txtQuestion.Clear();

            txtOptionA.Clear();
            txtOptionB.Clear();
            txtOptionC.Clear();
            txtOptionD.Clear();
        }

        private void IncrementQuestionNumber()
        {
            questionNo++;
            questionLabel.Text = questionNo.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Unsaved Data Will be Lost", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ClearAll();
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Do You Want To Close This Window? \n Unsaved Data Will be Lost", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ClearAll();
                Hide();
            }
        }

        public void GetHighestQuestionNumber(int lecturerID, string course, Label qNo)
        {
            // Query the examQuestions table to get the highest question number for the given lecturer ID
            string query = "SELECT MAX(Question_No) AS HighestQuestionNumber FROM examQuestions WHERE Lecturer_ID = @LecturerID AND Course = @Course";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@LecturerID", lecturerID);
            parameters.Add("@Course", course);

            List<Dictionary<string, object>> result = dbManager.GetData(query, parameters);

            // Get the highest question number from the query result
            int highestQuestionNumber = 0;
            if (result.Count > 0 && result[0]["HighestQuestionNumber"] != DBNull.Value)
            {
                highestQuestionNumber = Convert.ToInt32(result[0]["HighestQuestionNumber"]);
            }

            highestQuestionNumber += 1;
            // Update the label with the highest question number
            qNo.Text = highestQuestionNumber.ToString();
        }

        private void comboSelectDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSelectCourse.Items.Clear();
            questionLabel.Visible = false;

            string selectedDept = comboSelectDept.SelectedItem.ToString();

            // Get the courses for the selected department
            string query = "SELECT Course_Code FROM courses WHERE Department = @dept";
            Dictionary<string, object> parameters = new Dictionary<string, object> { { "@dept", selectedDept } };
            List<Dictionary<string, object>> courses = dbManager.GetData(query, parameters);

            // Add the data to the combobox, checking for duplicates
            HashSet<string> uniqueCourses = new HashSet<string>(); // use HashSet to store unique values
            foreach (Dictionary<string, object> course in courses)
            {
                string columnBValue = course["Course_Code"].ToString();
                if (!uniqueCourses.Contains(columnBValue))
                {
                    comboSelectCourse.Items.Add(columnBValue);
                    uniqueCourses.Add(columnBValue);
                }
            }
        }


        void GetLecturerID()
        {
            Form parentForm = this.ParentForm;
            if (parentForm != null)
            {
                Panel dashboardPanel = parentForm.Controls["dashboardPanel"] as Panel;
                if (dashboardPanel != null)
                {
                    Label labelLecturerID = dashboardPanel.Controls["labelLecturerID"] as Label;
                    if (labelLecturerID != null && int.TryParse(labelLecturerID.Text, out lecturerID))
                    {
                        // Successful
                        // Output is already gotten in this if function.
                    }
                }
            }
        }

        private void comboSelectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the highest question number for the given lecturer ID
            Form parentForm = this.ParentForm;
            if (parentForm != null)
            {
                Panel dashboardPanel = parentForm.Controls["dashboardPanel"] as Panel;
                if (dashboardPanel != null)
                {
                    Label labelLecturerID = dashboardPanel.Controls["labelLecturerID"] as Label;
                    string course = comboSelectCourse.SelectedItem.ToString();
                    if (labelLecturerID != null && int.TryParse(labelLecturerID.Text, out lecturerID) && course != null)
                    {
                        //GetHighestQuestionNumber(lecturerID, questionLabel);
                        GetHighestQuestionNumber(lecturerID, course, questionLabel);
                        if (int.TryParse(questionLabel.Text, out questionNo))
                        {
                            // Successfully parsed the question number
                            questionLabel.Visible = true;
                        }
                        else
                        {
                            // Failed to parse the question number
                            //MessageBox.Show("Failed to parse the question number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Failed to get the lecturer ID label or parse its text
                        //MessageBox.Show("Failed to get the lecturer ID or parse its text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Failed to get the dashboard panel
                    // MessageBox.Show("Failed to get the dashboard panel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Failed to get the parent form
                // MessageBox.Show("Failed to get the parent form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
