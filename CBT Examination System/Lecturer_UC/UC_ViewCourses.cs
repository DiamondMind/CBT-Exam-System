using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBT_Examination_System
{
    public partial class UC_ViewCourses : UserControl
    {
        int m_lecturerID;
        DatabaseManager databaseManager = new DatabaseManager();

        public UC_ViewCourses()
        {
            InitializeComponent();
        }

        internal void ConstructTable(string lecturerID)
        {
            int _lecturerID = int.Parse(lecturerID);
            m_lecturerID = _lecturerID;

            string query = "SELECT * FROM courses WHERE Lecturer_ID = @lecturerID";
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@lecturerID", _lecturerID);

            List<Dictionary<string, object>> data = databaseManager.GetData(query, parameters);

            // If the data is empty, display a message and return
            if (data.Count == 0)
            {
                MessageBox.Show("No courses found.", "Empty Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataGridCourses.Columns.Clear();
            dataGridCourses.Rows.Clear();

            // Create columns in the DataGridView control (excluding the "No" column)
            foreach (string columnName in data[0].Keys)
            {
                if (columnName != "No")
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.Name = columnName;
                    column.HeaderText = columnName;
                    dataGridCourses.Columns.Add(column);
                }
            }

            // Add a new first column called "S/N" as primary key
            DataGridViewTextBoxColumn snColumn = new DataGridViewTextBoxColumn();
            snColumn.Name = "S/N";
            snColumn.HeaderText = "S/N";
            dataGridCourses.Columns.Insert(0, snColumn);

            // Populate the DataGridView control with data (excluding the "No" column)
            int sn = 1;
            foreach (Dictionary<string, object> row in data)
            {
                List<object> rowDataList = new List<object>();
                rowDataList.Add(sn);
                sn++;

                foreach (KeyValuePair<string, object> pair in row)
                {
                    if (pair.Key != "No")
                    {
                        rowDataList.Add(pair.Value);
                    }
                }
                dataGridCourses.Rows.Add(rowDataList.ToArray());
            }
        }

        private void comboBoxLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLevel = comboBoxLevel.SelectedItem.ToString();

            if (selectedLevel == "All") // if "All" is selected, retrieve all data
            {

                // Define the query and parameters
                string query = "SELECT * FROM courses WHERE Lecturer_ID = @LecturerID";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@LecturerID", m_lecturerID);

                // Retrieve the data from the database
                List<Dictionary<string, object>> data = databaseManager.GetData(query, parameters);

                if (data.Count == 0) // Check if the data is empty
                {
                    MessageBox.Show("No courses found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Clear the DataGridView control
                dataGridCourses.Rows.Clear();
                dataGridCourses.Columns.Clear();

                // Create columns in the DataGridView control
                foreach (KeyValuePair<string, object> pair in data[0])
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.Name = pair.Key;
                    column.HeaderText = pair.Key;
                    dataGridCourses.Columns.Add(column);
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
                    dataGridCourses.Rows.Add(rowData);
                }
            }
            else // if any other level is selected, filter the data by level
            {
                // Define the query and parameters
                string query = "SELECT * FROM courses WHERE Level = @Level AND Lecturer_ID = @LecturerID";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@Level", selectedLevel);
                parameters.Add("@LecturerID", m_lecturerID);

                // Retrieve the data from the database
                List<Dictionary<string, object>> data = databaseManager.GetData(query, parameters);

                if (data.Count == 0) // Check if the data is empty
                {
                    MessageBox.Show("No courses found for selected level", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Clear the DataGridView control
                dataGridCourses.Rows.Clear();
                dataGridCourses.Columns.Clear();

                // Create columns in the DataGridView control
                foreach (KeyValuePair<string, object> pair in data[0])
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.Name = pair.Key;
                    column.HeaderText = pair.Key;
                    dataGridCourses.Columns.Add(column);
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
                    dataGridCourses.Rows.Add(rowData);
                }
            }
        }

        private void comboBoxDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDept = comboBoxDept.SelectedItem.ToString();

            if (selectedDept == "All") // if "All" is selected, retrieve all data
            {
                // Define the query and parameters
                string query = "SELECT * FROM courses WHERE Lecturer_ID = @LecturerID";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@LecturerID", m_lecturerID);

                // Retrieve the data from the database
                List<Dictionary<string, object>> data = databaseManager.GetData(query, parameters);

                if (data.Count == 0) // Check if the data is empty
                {
                    MessageBox.Show("No courses found for selected department", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Clear the DataGridView control
                dataGridCourses.Rows.Clear();
                dataGridCourses.Columns.Clear();

                // Create columns in the DataGridView control
                foreach (KeyValuePair<string, object> pair in data[0])
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.Name = pair.Key;
                    column.HeaderText = pair.Key;
                    dataGridCourses.Columns.Add(column);
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
                    dataGridCourses.Rows.Add(rowData);
                }
            }
            else    // if any other dept is selected, filter the data by dept
            {
                // Define the query and parameters
                string query = "SELECT * FROM courses WHERE Department = @Department AND Lecturer_ID = @LecturerID";
                Dictionary<string, object> parameters = new Dictionary<string, object>();
                parameters.Add("@Department", selectedDept);
                parameters.Add("@LecturerID", m_lecturerID);

                // Retrieve the data from the database
                List<Dictionary<string, object>> data = databaseManager.GetData(query, parameters);

                if (data.Count == 0) // Check if the data is empty
                {
                    MessageBox.Show("No courses found for selected department", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Clear the DataGridView control
                dataGridCourses.Rows.Clear();
                dataGridCourses.Columns.Clear();

                // Create columns in the DataGridView control
                foreach (KeyValuePair<string, object> pair in data[0])
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.Name = pair.Key;
                    column.HeaderText = pair.Key;
                    dataGridCourses.Columns.Add(column);
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
                    dataGridCourses.Rows.Add(rowData);
                }

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridCourses.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridCourses.SelectedRows[0].Index;
                int courseId = Convert.ToInt32(dataGridCourses.Rows[rowIndex].Cells["No"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Delete the record from the database
                    string query = "DELETE FROM courses WHERE No = @No";
                    Dictionary<string, object> parameters = new Dictionary<string, object>();
                    parameters.Add("@No", courseId);
                    databaseManager.UpdateData(query, parameters);

                    // Remove the row from the DataGridView control
                    dataGridCourses.Rows.RemoveAt(rowIndex);
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
