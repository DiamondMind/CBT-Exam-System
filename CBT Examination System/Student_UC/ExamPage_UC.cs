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
    public partial class ExamPage_UC : UserControl
    {
        int maxQuestions;
        List<int> questionNumbers;  
        int currentQuestionIndex;
        Dictionary<int, string> selectedAnswers;
        int totalScore = 0;

        TimeSpan examDuration;
        DatabaseManager dbManager = new DatabaseManager();

        // For updating score table
        public string courseTitle;
        public string courseCode;
        public int units;
        public string MatricNo;
        public string fullName;
        public string level;
        public string dept;
        public string session;
        public string lecturerName;

        public ExamPage_UC()
        {
            InitializeComponent();

            selectedAnswers = new Dictionary<int, string>();

            // Set the initial text for the timerLabel
            timerLabel.Text = examDuration.ToString(@"hh\:mm\:ss");
        }

        public void DisplayQuestionDetails(string questionNumber)
        {
            questionLabel.Text = (currentQuestionIndex + 1).ToString();

            // Retrieve the question details and options from the database
            string query = "SELECT Question, OptionA, OptionB, OptionC, OptionD FROM examQuestions WHERE Question_No = @questionNumber AND Course = @course";
           
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@questionNumber", questionNumber);
            parameters.Add("@course", labelCourse.Text);

            List<Dictionary<string, object>> result = dbManager.GetData(query, parameters);

            // Set the text of the questionDetails label to the question details and options from the database
            if (result.Count > 0)
            {
                Dictionary<string, object> row = result[0];
                string question = row["Question"].ToString();
                string optionA = row["OptionA"].ToString();
                string optionB = row["OptionB"].ToString();
                string optionC = row["OptionC"].ToString();
                string optionD = row["OptionD"].ToString();

                // Display the question and options with line breaks and character limit
                int characterLimit = 60;
                string formattedQuestion = FormatText(question, characterLimit);
                questionDetails.Text = formattedQuestion + "\n\nOption A:\n" + FormatText(optionA, characterLimit) + "\n\nOption B:\n" + FormatText(optionB, characterLimit) 
                                                            + "\n\nOption C:\n" + FormatText(optionC, characterLimit) + "\n\nOption D:\n" + FormatText(optionD, characterLimit);


                // Start the exam timer
                examTimer.Start();

                // Set the selected answer in comboSelectAnswer based on the previously selected answer
                if (selectedAnswers.ContainsKey(currentQuestionIndex))
                {
                    string selectedAnswer = selectedAnswers[currentQuestionIndex];
                    comboSelectAnswer.SelectedItem = selectedAnswer;
                }
                else
                {
                    comboSelectAnswer.SelectedIndex = 0;
                }
            }
            else
            {
                questionDetails.Text = "Question details not found";
            }

            #region Buttons Visibility
            // Turn off buttons at the right conditions
            if ((currentQuestionIndex + 1) == questionNumbers.Count)
            {
                btnNext.Enabled = false;
                btnNext.Visible = false;
            }
            else
            {
                btnNext.Enabled = true;
                btnNext.Visible = true;
            }

            if ((currentQuestionIndex + 1) == 1)
            {
                btnPrevious.Visible = false;
                btnPrevious.Enabled = false;
            }
            else
            {
                btnPrevious.Visible = true;
                btnPrevious.Enabled = true;
            }
            #endregion
        }

        public void SetCourse(string courseText)
        {
            labelCourse.Text = courseText;
            courseCode = courseText;    // for updating score table
            maxQuestions = GetMaxQuestionNoByCourse(courseText);

            // Generate a list of randomized question numbers
            questionNumbers = Enumerable.Range(1, maxQuestions).OrderBy(x => Guid.NewGuid()).ToList();

            // Set the initial question index
            currentQuestionIndex = 0;

            // Display the first question
            DisplayQuestionDetails(questionNumbers[currentQuestionIndex].ToString());

            int examDurationInSeconds = RetrieveExamDuration(courseText);
            examDuration = TimeSpan.FromSeconds(examDurationInSeconds);

        }

        public int GetMaxQuestionNoByCourse(string course)
        {
            int maxQuestionNo = 0;

            string query = "SELECT MAX(Question_No) AS MaxQuestionNo FROM examQuestions WHERE Course = @Course";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@Course", course);

            List<Dictionary<string, object>> result = dbManager.GetData(query, parameters);

            if (result.Count > 0 && result[0]["MaxQuestionNo"] != DBNull.Value)
            {
                maxQuestionNo = Convert.ToInt32(result[0]["MaxQuestionNo"]);
            }


            return maxQuestionNo;
        }

        private string FormatText(string text, int characterLimit)
        {
            string[] words = text.Split(' ');
            string formattedText = "";
            int lineLength = 0;

            foreach (string word in words)
            {
                if (lineLength + word.Length + 1 <= characterLimit)
                {
                    formattedText += word + " ";
                    lineLength += word.Length + 1;
                }
                else
                {
                    formattedText += "\n" + word + " ";
                    lineLength = word.Length + 1;
                }
            }

            return formattedText.TrimEnd();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Calculate the score for the current question
            //CalculateScore();

            // Store the selected answer for the current question
            selectedAnswers[currentQuestionIndex] = comboSelectAnswer.SelectedItem.ToString();

            // Move to the next question
            int nextQuestionIndex = currentQuestionIndex + 1;

            if (comboSelectAnswer.SelectedIndex == 0)
            {
                if (MessageBox.Show("This question has not been answered.\nDo you want to move to the next question?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    // Check if there is a next question available
                    if (nextQuestionIndex < questionNumbers.Count)
                    {
                        currentQuestionIndex = nextQuestionIndex;
                        DisplayQuestionDetails(questionNumbers[currentQuestionIndex].ToString());
                    }
                    else
                    {
                        MessageBox.Show("You have reached the end of the questions.");
                        // Handle the scenario when the last question is reached
                        
                    }
                }
            }
            else
            {
                // Check if there is a next question available
                if (nextQuestionIndex < questionNumbers.Count)
                {
                    currentQuestionIndex = nextQuestionIndex;
                    DisplayQuestionDetails(questionNumbers[currentQuestionIndex].ToString());
                }
                else
                {
                    MessageBox.Show("You have reached the end of the questions.");
                    // Handle the scenario when the last question is reached
                }
            }

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            // Store the selected answer for the current question
            selectedAnswers[currentQuestionIndex] = comboSelectAnswer.SelectedItem.ToString();

            // Move to the previous question
            int previousQuestionIndex = currentQuestionIndex - 1;

            if (comboSelectAnswer.SelectedIndex == 0)
            {
                if (MessageBox.Show("This question has not been answered.\nDo you want to move to the previous question?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (previousQuestionIndex >= 0)
                    {
                        currentQuestionIndex = previousQuestionIndex;
                        DisplayQuestionDetails(questionNumbers[currentQuestionIndex].ToString());
                    }
                    else
                    {
                        MessageBox.Show("This is the first question.");
                        // Handle the scenario when the first question is reached
                    }
                }
            }
            else
            {
                if (previousQuestionIndex >= 0)
                {
                    currentQuestionIndex = previousQuestionIndex;
                    DisplayQuestionDetails(questionNumbers[currentQuestionIndex].ToString());
                }
                else
                {
                    MessageBox.Show("This is the first question.");
                    // Handle the scenario when the first question is reached
                }
            }

        }

        private void btnGoToQuestion_Click(object sender, EventArgs e)
        {
            string input = mskTxtGotoQuestion.Text;

            if (int.TryParse(input, out int selectedQuestionNumber))
            {
                if (selectedQuestionNumber >= 1 && selectedQuestionNumber <= maxQuestions)
                {
                    if (MessageBox.Show("Do you want to move to this question?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        currentQuestionIndex = selectedQuestionNumber - 1;
                        DisplayQuestionDetails(questionNumbers[currentQuestionIndex].ToString());
                        mskTxtGotoQuestion.Clear();
                    }

                }
                else
                {
                    MessageBox.Show("Invalid question number. Please enter a valid question number.");
                    mskTxtGotoQuestion.Clear();
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to submit.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CalculateScore();
                DisplayScore();
                CollectStudentInformation();
                InsertStudentResults();
            }

        }

        private void CalculateScore()
        {
            // Calculate the score based on selected answers and actual answers from the database            
            foreach (var pair in selectedAnswers)
            {
                int questionIndex = pair.Key;
                string selectedAnswer = pair.Value;

                // Retrieve the correct answer from the database for the question
                string query = "SELECT Answer FROM examQuestions WHERE Question_No = @questionNumber AND Course = @course";

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@questionNumber", questionNumbers[questionIndex]);
                parameters.Add("@course", labelCourse.Text);

                List<Dictionary<string, object>> result = dbManager.GetData(query, parameters);

                if (result.Count > 0)
                {
                    Dictionary<string, object> row = result[0];
                    string correctAnswer = row["Answer"].ToString();

                    // Compare the selected answer with the correct answer
                    if (selectedAnswer == correctAnswer)
                    {
                        // Increment the score if the answer is correct
                        totalScore++;
                    }
                }
            }
        }

        private void comboSelectAnswer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the selected answer when the combo box selection changes
            if (currentQuestionIndex >= 0)
            {
                selectedAnswers[currentQuestionIndex] = comboSelectAnswer.SelectedItem.ToString();
            }
        }

        private void DisplayScore()
        {
            StringBuilder sb = new StringBuilder();
            int totalScore = 0;

            foreach (var pair in selectedAnswers)
            {
                int questionIndex = pair.Key;
                string selectedAnswer = pair.Value;

                // Retrieve the correct answer from the database for the question
                string query = "SELECT Answer FROM examQuestions WHERE Question_No = @questionNumber AND Course = @course";

                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@questionNumber", questionNumbers[questionIndex]);
                parameters.Add("@course", labelCourse.Text);

                List<Dictionary<string, object>> result = dbManager.GetData(query, parameters);

                if (result.Count > 0)
                {
                    Dictionary<string, object> row = result[0];
                    string correctAnswer = row["Answer"].ToString();

                    // Compare the selected answer with the correct answer
                    bool isCorrect = (selectedAnswer == correctAnswer);
                    if (isCorrect)
                    {
                        totalScore++;
                    }

                    // Append the question and selected answer to the StringBuilder
                    sb.AppendLine($"Question {questionIndex + 1}: Selected Answer: {selectedAnswer} - {(isCorrect ? "Correct" : "Incorrect")}");
                }
            }

            // Display the total score and selected answers
            sb.AppendLine($"Total Score: {totalScore} / {maxQuestions}");
            MessageBox.Show("Exam Marked\n\n" + sb.ToString());
        }

        private int RetrieveExamDuration(string courseCode)
        {
            // N.B: This method also fetches the course title and units from the table.
            // They are used when adding score to the table after submitting.

            string query = "SELECT Exam_Timer, Course_Title, Units FROM courses WHERE Course_Code = @courseCode";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@courseCode", courseCode);

            List<Dictionary<string, object>> result = dbManager.GetData(query, parameters);

            if (result.Count > 0 && result[0]["Exam_Timer"] != DBNull.Value)
            {
                TimeSpan examDuration;
                if (TimeSpan.TryParse(result[0]["Exam_Timer"].ToString(), out examDuration))
                {
                    // Retrieve the course title and units from the selected row
                    courseTitle = result[0]["Course_Title"].ToString();
                    units = Convert.ToInt32(result[0]["Units"]);

                    // Return the total seconds of the exam duration
                    return (int)examDuration.TotalSeconds;
                }
            }

            // Default exam duration if retrieval fails or parsing fails
            return 0;
        }

        private void examTimer_Tick(object sender, EventArgs e)
        {
            examDuration = examDuration.Subtract(TimeSpan.FromSeconds(1));

            if (examDuration <= TimeSpan.Zero)
            {
                examTimer.Stop();
                // Handle the scenario when the exam time is up
                MessageBox.Show("Time's up! The exam has ended.\nYour Answers have been automatically submitted.");
                CalculateScore();
                DisplayScore();
                CollectStudentInformation();
                InsertStudentResults();
            }
            else
            {
                // Update the displayed time in the timerLabel
                timerLabel.Text = examDuration.ToString(@"hh\:mm\:ss");

                // Check if there is 1 minute left (60 seconds)
                TimeSpan oneMinute = TimeSpan.FromMinutes(1);
                if (examDuration == oneMinute)
                {
                    MessageBox.Show("Only 1 minute remaining in the exam!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void CollectStudentInformation()
        {
            Form parentForm = this.FindForm();

            if (parentForm is StudentDashboard parentFormInstance)
            {
                MatricNo = parentFormInstance.matricNo;
                fullName = parentFormInstance.fullName;
                level = parentFormInstance.level;
                dept = parentFormInstance.dept;
                session = parentFormInstance.session;
            }
            else
            {
                // Handle the scenario when the parent form is not of the expected type
                MessageBox.Show("Error: Unable to collect student information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetLecturerName()
        {
            string query = "SELECT Lecturer_Name FROM courses WHERE Course_Code = @courseCode";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@courseCode", courseCode);

            List<Dictionary<string, object>> rows = dbManager.GetData(query, parameters);

            if (rows.Count > 0)
            {
                string lecturerName = rows[0]["Lecturer_Name"].ToString();
                return lecturerName;
            }
            else
            {
                return string.Empty;
            }
        }


        private void InsertStudentResults()
        {

            string query = "INSERT INTO studentsResults (Matric_No, Full_Name, Session, Level, Department, Lecturer_Name, Course_Title, Course_Code, Units, Score) " +
                                          "VALUES (@MatricNo, @FullName, @Session, @Level, @Department, @lecturerName, @CourseTitle, @CourseCode, @Units, @Score)";

            // Create a dictionary to store the parameter values
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@MatricNo", MatricNo);
            parameters.Add("@FullName", fullName);
            parameters.Add("@Session", session);
            parameters.Add("@Level", level);
            parameters.Add("@Department", dept);
            parameters.Add("lecturerName", GetLecturerName());
            parameters.Add("@CourseTitle", courseTitle);
            parameters.Add("@CourseCode", courseCode);
            parameters.Add("@Units", units);
            string score = "" + totalScore + " / " + maxQuestions;
            parameters.Add("@Score", score);

            // Execute query to insert new row
            int rowsAffected = dbManager.UpdateData(query, parameters);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Results stored successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CustomClose();
            }
            else
            {
                MessageBox.Show("Failed to store results.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void CustomClose()
        {
            questionDetails.ResetText();
            timerLabel.ResetText();
            examTimer.Stop();
            labelCourse.ResetText();
            questionLabel.ResetText();
            comboSelectAnswer.SelectedIndex = 0;
            mskTxtGotoQuestion.Clear();
            this.Visible = false;
            this.SendToBack();

            StudentDashboard parentForm = this.Parent as StudentDashboard;
            if (parentForm != null)
            {
                parentForm.examStarted = false;
            }
        }
    }
}
