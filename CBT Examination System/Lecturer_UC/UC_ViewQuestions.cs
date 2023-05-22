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
    public partial class UC_ViewQuestions : UserControl
    {
        DatabaseManager dbManager = new DatabaseManager();
        int m_lecturerID;

        public UC_ViewQuestions()
        {
            InitializeComponent();
        }

        internal void ConstructTable(string lecturerID)
        {
            int _lecturerID = int.Parse(lecturerID);
            m_lecturerID = _lecturerID;

            string query = "SELECT * FROM examQuestions WHERE Lecturer_ID = @lecturerID";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@lecturerID", _lecturerID);

            List<Dictionary<string, object>> data = dbManager.GetData(query, parameters);

            // If the data is empty, display a message and return
            if (data.Count == 0)
            {
                MessageBox.Show("No questions found.", "Empty Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataGridExamQuestions.Columns.Clear();
            dataGridExamQuestions.Rows.Clear();

            // Create columns in the DataGridView control
            DataGridViewTextBoxColumn snColumn = new DataGridViewTextBoxColumn();
            snColumn.Name = "S/N";
            snColumn.HeaderText = "S/N";
            dataGridExamQuestions.Columns.Add(snColumn);

            foreach (string columnName in data[0].Keys)
            {
                if (columnName != "S/N")
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.Name = columnName;
                    column.HeaderText = columnName;
                    dataGridExamQuestions.Columns.Add(column);
                }
            }

            // Populate the DataGridView control with data
            foreach (Dictionary<string, object> row in data)
            {
                //object[] rowData = new object[row.Count];
                object[] rowData = new object[dataGridExamQuestions.Columns.Count];

                int i = 1; // start at 1 to skip the S/N column
                foreach (object value in row.Values)
                {
                    rowData[i] = value;
                    i++;
                }

                // Generate the S/N column value based on the row index
                rowData[0] = dataGridExamQuestions.Rows.Count + 1;

                dataGridExamQuestions.Rows.Add(rowData);
            }

            FillCoursesCombo();
        }

        void FillCoursesCombo()
        {
            string query = "SELECT Course FROM examQuestions WHERE Lecturer_ID = @lecturerID";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@lecturerID", m_lecturerID);

            List<Dictionary<string, object>> courses = dbManager.GetData(query, parameters);

            // Keep track of the items already added to the comboBox
            HashSet<string> addedItems = new HashSet<string>();

            // Add the data to the combobox
            foreach (Dictionary<string, object> course in courses)
            {
                string columnBValue = course["Course"].ToString();

                // Check if the item has already been added to the comboBox
                if (!addedItems.Contains(columnBValue))
                {
                    comboBoxCourse.Items.Add(columnBValue);

                    // Add the item to the HashSet
                    addedItems.Add(columnBValue);
                }
            }
        }

        private void comboBoxDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDept = comboBoxDept.SelectedItem.ToString();


            if (selectedDept == "All") // if "All" is selected, retrieve all data
            {
                // Define the query and parameters
                string query = "SELECT * FROM examQuestions WHERE Lecturer_ID = @LecturerID";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@LecturerID", m_lecturerID);

                // Retrieve the data from the database
                List<Dictionary<string, object>> data = dbManager.GetData(query, parameters);

                if (data.Count == 0) // Check if the data is empty
                {
                    MessageBox.Show("No questions found for selected department", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Clear the DataGridView control
                dataGridExamQuestions.Rows.Clear();
                dataGridExamQuestions.Columns.Clear();

                // Create columns in the DataGridView control
                foreach (KeyValuePair<string, object> pair in data[0])
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.Name = pair.Key;
                    column.HeaderText = pair.Key;
                    dataGridExamQuestions.Columns.Add(column);
                }

                // Populate the DataGridView control with data
                foreach (Dictionary<string, object> row in data)
                {
                    object[] rowData = new object[row.Count];
                    int i = 0;
                    foreach (KeyValuePair<string, object> pair in row)
                    {
                        rowData[i] = pair.Value;
                        i++;
                    }
                    dataGridExamQuestions.Rows.Add(rowData);
                }
            }
            else    // if any other dept is selected, filter the data by dept
            {
                // Define the query and parameters
                string query = "SELECT * FROM examQuestions WHERE Department = @Department AND Lecturer_ID = @LecturerID";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@Department", selectedDept);
                parameters.Add("@LecturerID", m_lecturerID);

                // Retrieve the data from the database
                List<Dictionary<string, object>> data = dbManager.GetData(query, parameters);

                if (data.Count == 0) // Check if the data is empty
                {
                    MessageBox.Show("No questions found for selected department", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Clear the DataGridView control
                dataGridExamQuestions.Rows.Clear();
                dataGridExamQuestions.Columns.Clear();

                // Create columns in the DataGridView control
                foreach (KeyValuePair<string, object> pair in data[0])
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.Name = pair.Key;
                    column.HeaderText = pair.Key;
                    dataGridExamQuestions.Columns.Add(column);
                }

                // Populate the DataGridView control with data
                foreach (Dictionary<string, object> row in data)
                {
                    object[] rowData = new object[row.Count];
                    int i = 0;
                    foreach (KeyValuePair<string, object> pair in row)
                    {
                        rowData[i] = pair.Value;
                        i++;
                    }
                    dataGridExamQuestions.Rows.Add(rowData);
                }
            }

        }

        private void comboBoxCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCourse = comboBoxCourse.SelectedItem.ToString();


            if (selectedCourse == "All") // if "All" is selected, retrieve all data
            {
                // Define the query and parameters
                string query = "SELECT * FROM examQuestions WHERE Lecturer_ID = @LecturerID";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@LecturerID", m_lecturerID);

                // Retrieve the data from the database
                List<Dictionary<string, object>> data = dbManager.GetData(query, parameters);

                if (data.Count == 0) // Check if the data is empty
                {
                    MessageBox.Show("No questions found for selected course", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Clear the DataGridView control
                dataGridExamQuestions.Rows.Clear();
                dataGridExamQuestions.Columns.Clear();

                // Create columns in the DataGridView control
                foreach (KeyValuePair<string, object> pair in data[0])
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.Name = pair.Key;
                    column.HeaderText = pair.Key;
                    dataGridExamQuestions.Columns.Add(column);
                }

                // Populate the DataGridView control with data
                foreach (Dictionary<string, object> row in data)
                {
                    object[] rowData = new object[row.Count];
                    int i = 0;
                    foreach (KeyValuePair<string, object> pair in row)
                    {
                        rowData[i] = pair.Value;
                        i++;
                    }
                    dataGridExamQuestions.Rows.Add(rowData);
                }
            }
            else    // if any other course is selected, filter the data by course
            {
                // Define the query and parameters
                string query = "SELECT * FROM examQuestions WHERE Course = @Course AND Lecturer_ID = @LecturerID";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@Course", selectedCourse);
                parameters.Add("@LecturerID", m_lecturerID);

                // Retrieve the data from the database
                List<Dictionary<string, object>> data = dbManager.GetData(query, parameters);

                if (data.Count == 0) // Check if the data is empty
                {
                    MessageBox.Show("No questions found for selected course", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Clear the DataGridView control
                dataGridExamQuestions.Rows.Clear();
                dataGridExamQuestions.Columns.Clear();

                // Create columns in the DataGridView control
                foreach (KeyValuePair<string, object> pair in data[0])
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.Name = pair.Key;
                    column.HeaderText = pair.Key;
                    dataGridExamQuestions.Columns.Add(column);
                }

                // Populate the DataGridView control with data
                foreach (Dictionary<string, object> row in data)
                {
                    object[] rowData = new object[row.Count];
                    int i = 0;
                    foreach (KeyValuePair<string, object> pair in row)
                    {
                        rowData[i] = pair.Value;
                        i++;
                    }
                    dataGridExamQuestions.Rows.Add(rowData);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridExamQuestions.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridExamQuestions.SelectedRows[0].Index;
                int courseId = Convert.ToInt32(dataGridExamQuestions.Rows[rowIndex].Cells["Question_No"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Delete the record from the database
                    string query = "DELETE FROM examQuestions WHERE Question_No = @Question_No";
                    Dictionary<string, object> parameters = new Dictionary<string, object>();
                    parameters.Add("@Question_No", courseId);
                    dbManager.UpdateData(query, parameters);

                    // Remove the row from the DataGridView control
                    dataGridExamQuestions.Rows.RemoveAt(rowIndex);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Do You Want To Close This Window?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Hide();
            }
        }

    }
}
