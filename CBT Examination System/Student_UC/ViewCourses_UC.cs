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
    public partial class ViewCourses_UC : UserControl
    {
        string _level;
        string _dept;
        bool comboFilled = false;
        DatabaseManager databaseManager = new DatabaseManager();

        public ViewCourses_UC()
        {
            InitializeComponent();
        }

        internal void ConstructTable(string level, string department)
        {
            _level = level;
            _dept = department;

            //string query = "SELECT * FROM courses WHERE Level = @level AND Department = @department";
            string query = "SELECT * FROM courses WHERE Level = @level AND (Department = @department OR Department = 'All')";
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@level", level);
            parameters.Add("@department", department);

            List<Dictionary<string, object>> data = databaseManager.GetData(query, parameters);

            // If the data is empty, display a message and return
            if (data.Count == 0)
            {
                MessageBox.Show("No courses found. \n Your Lecturer is yet to add courses for your class", "Empty Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataGridStudentCourses.Columns.Clear();
            dataGridStudentCourses.Rows.Clear();

            // Add the S/N column as the first column in the DataGridView
            DataGridViewTextBoxColumn snColumn = new DataGridViewTextBoxColumn();
            snColumn.Name = "S/N";
            snColumn.HeaderText = "S/N";
            dataGridStudentCourses.Columns.Add(snColumn);

            // Create columns in the DataGridView control (excluding the Lecturer_ID and No columns)
            foreach (string columnName in data[0].Keys)
            {
                if (columnName != "Lecturer_ID" && columnName != "No")
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.Name = columnName;
                    column.HeaderText = columnName;
                    dataGridStudentCourses.Columns.Add(column);
                }
            }

            // Populate the DataGridView control with data (excluding the Lecturer_ID and No columns)
            int sn = 1;
            foreach (Dictionary<string, object> row in data)
            {
                List<object> rowDataList = new List<object>();
                rowDataList.Add(sn);
                sn++;

                foreach (KeyValuePair<string, object> pair in row)
                {
                    if (pair.Key != "Lecturer_ID" && pair.Key != "No")
                    {
                        rowDataList.Add(pair.Value);
                    }
                }

                dataGridStudentCourses.Rows.Add(rowDataList.ToArray());

            }

            if(comboFilled == false)
            {
                FillComboBox("Lecturer_Name".ToString(), comboSelectLecturer);
                FillComboBox("Units".ToString(), comboSelectUnits);
                comboFilled = true;
            }
            
        }

        private void FillComboBox(string columnName, ComboBox comboBox)
        {
            string query = $"SELECT DISTINCT {columnName} FROM courses WHERE Level = @level";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@level", _level);

            List<Dictionary<string, object>> items = databaseManager.GetData(query, parameters);

            // Keep track of the items already added to the comboBox
            HashSet<string> addedItems = new HashSet<string>();

            // Add the data to the combobox
            foreach (Dictionary<string, object> item in items)
            {
                string columnValue = item[columnName].ToString();

                // Check if the item has already been added to the comboBox
                if (!addedItems.Contains(columnValue))
                {
                    comboBox.Items.Add(columnValue);

                    // Add the item to the HashSet
                    addedItems.Add(columnValue);
                }
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Do You Want To Close This Window?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Hide();
            }
        }

        private void comboSeelectLecturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedLectr = comboSelectLecturer.SelectedItem.ToString();

            if (selectedLectr == "All") // if "All" is selected, retrieve all data
            {
                string query = "SELECT * FROM courses WHERE Level = @level AND Department = @department";
                Dictionary<string, object> parameters = new Dictionary<string, object>();

                parameters.Add("@level", _level);
                parameters.Add("@department", _dept);

                List<Dictionary<string, object>> data = databaseManager.GetData(query, parameters);

                // If the data is empty, display a message and return
                if (data.Count == 0)
                {
                    MessageBox.Show("No courses found. \n Your Lecturer is yet to add courses for your class", "Empty Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridStudentCourses.Columns.Clear();
                dataGridStudentCourses.Rows.Clear();

                // Add the S/N column as the first column in the DataGridView
                DataGridViewTextBoxColumn snColumn = new DataGridViewTextBoxColumn();
                snColumn.Name = "S/N";
                snColumn.HeaderText = "S/N";
                dataGridStudentCourses.Columns.Add(snColumn);

                // Create columns in the DataGridView control (excluding the Lecturer_ID and No columns)
                foreach (string columnName in data[0].Keys)
                {
                    if (columnName != "Lecturer_ID" && columnName != "No")
                    {
                        DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                        column.Name = columnName;
                        column.HeaderText = columnName;
                        dataGridStudentCourses.Columns.Add(column);
                    }
                }

                // Populate the DataGridView control with data (excluding the Lecturer_ID and No columns)
                int sn = 1;
                foreach (Dictionary<string, object> row in data)
                {
                    List<object> rowDataList = new List<object>();
                    rowDataList.Add(sn);
                    sn++;

                    foreach (KeyValuePair<string, object> pair in row)
                    {
                        if (pair.Key != "Lecturer_ID" && pair.Key != "No")
                        {
                            rowDataList.Add(pair.Value);
                        }
                    }

                    dataGridStudentCourses.Rows.Add(rowDataList.ToArray());

                }
            }
            else    // if any other lecturer is selected, filter the data by dept
            {
                string query = "SELECT * FROM courses WHERE Level = @level AND Department = @department AND Lecturer_Name = @selecterLectr";
                Dictionary<string, object> parameters = new Dictionary<string, object>();

                parameters.Add("@level", _level);
                parameters.Add("@department", _dept);
                parameters.Add("@selecterLectr", selectedLectr);

                List<Dictionary<string, object>> data = databaseManager.GetData(query, parameters);

                // If the data is empty, display a message and return
                if (data.Count == 0)
                {
                    MessageBox.Show("No courses found. \n Your Lecturer is yet to add courses for your class", "Empty Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridStudentCourses.Columns.Clear();
                dataGridStudentCourses.Rows.Clear();

                // Add the S/N column as the first column in the DataGridView
                DataGridViewTextBoxColumn snColumn = new DataGridViewTextBoxColumn();
                snColumn.Name = "S/N";
                snColumn.HeaderText = "S/N";
                dataGridStudentCourses.Columns.Add(snColumn);

                // Create columns in the DataGridView control (excluding the Lecturer_ID and No columns)
                foreach (string columnName in data[0].Keys)
                {
                    if (columnName != "Lecturer_ID" && columnName != "No")
                    {
                        DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                        column.Name = columnName;
                        column.HeaderText = columnName;
                        dataGridStudentCourses.Columns.Add(column);
                    }
                }

                // Populate the DataGridView control with data (excluding the Lecturer_ID and No columns)
                int sn = 1;
                foreach (Dictionary<string, object> row in data)
                {
                    List<object> rowDataList = new List<object>();
                    rowDataList.Add(sn);
                    sn++;

                    foreach (KeyValuePair<string, object> pair in row)
                    {
                        if (pair.Key != "Lecturer_ID" && pair.Key != "No")
                        {
                            rowDataList.Add(pair.Value);
                        }
                    }

                    dataGridStudentCourses.Rows.Add(rowDataList.ToArray());

                }
            }

        }

        private void comboSelectUnits_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUnits = comboSelectUnits.SelectedItem.ToString();

            if (selectedUnits == "All") // if "All" is selected, retrieve all data
            {
                string query = "SELECT * FROM courses WHERE Level = @level AND Department = @department";
                Dictionary<string, object> parameters = new Dictionary<string, object>();

                parameters.Add("@level", _level);
                parameters.Add("@department", _dept);

                List<Dictionary<string, object>> data = databaseManager.GetData(query, parameters);

                // If the data is empty, display a message and return
                if (data.Count == 0)
                {
                    MessageBox.Show("No courses found. \n Your Lecturer is yet to add courses for your class", "Empty Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridStudentCourses.Columns.Clear();
                dataGridStudentCourses.Rows.Clear();

                // Add the S/N column as the first column in the DataGridView
                DataGridViewTextBoxColumn snColumn = new DataGridViewTextBoxColumn();
                snColumn.Name = "S/N";
                snColumn.HeaderText = "S/N";
                dataGridStudentCourses.Columns.Add(snColumn);

                // Create columns in the DataGridView control (excluding the Lecturer_ID and No columns)
                foreach (string columnName in data[0].Keys)
                {
                    if (columnName != "Lecturer_ID" && columnName != "No")
                    {
                        DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                        column.Name = columnName;
                        column.HeaderText = columnName;
                        dataGridStudentCourses.Columns.Add(column);
                    }
                }

                // Populate the DataGridView control with data (excluding the Lecturer_ID and No columns)
                int sn = 1;
                foreach (Dictionary<string, object> row in data)
                {
                    List<object> rowDataList = new List<object>();
                    rowDataList.Add(sn);
                    sn++;

                    foreach (KeyValuePair<string, object> pair in row)
                    {
                        if (pair.Key != "Lecturer_ID" && pair.Key != "No")
                        {
                            rowDataList.Add(pair.Value);
                        }
                    }

                    dataGridStudentCourses.Rows.Add(rowDataList.ToArray());

                }
            }
            else    
            {
                string query = "SELECT * FROM courses WHERE Level = @level AND Department = @department AND Units = @selectedUnits";
                Dictionary<string, object> parameters = new Dictionary<string, object>();

                parameters.Add("@level", _level);
                parameters.Add("@department", _dept);
                parameters.Add("@selectedUnits", selectedUnits);

                List<Dictionary<string, object>> data = databaseManager.GetData(query, parameters);

                // If the data is empty, display a message and return
                if (data.Count == 0)
                {
                    MessageBox.Show("No courses found. \n Your Lecturer is yet to add courses for your class", "Empty Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridStudentCourses.Columns.Clear();
                dataGridStudentCourses.Rows.Clear();

                // Add the S/N column as the first column in the DataGridView
                DataGridViewTextBoxColumn snColumn = new DataGridViewTextBoxColumn();
                snColumn.Name = "S/N";
                snColumn.HeaderText = "S/N";
                dataGridStudentCourses.Columns.Add(snColumn);

                // Create columns in the DataGridView control (excluding the Lecturer_ID and No columns)
                foreach (string columnName in data[0].Keys)
                {
                    if (columnName != "Lecturer_ID" && columnName != "No")
                    {
                        DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                        column.Name = columnName;
                        column.HeaderText = columnName;
                        dataGridStudentCourses.Columns.Add(column);
                    }
                }

                // Populate the DataGridView control with data (excluding the Lecturer_ID and No columns)
                int sn = 1;
                foreach (Dictionary<string, object> row in data)
                {
                    List<object> rowDataList = new List<object>();
                    rowDataList.Add(sn);
                    sn++;

                    foreach (KeyValuePair<string, object> pair in row)
                    {
                        if (pair.Key != "Lecturer_ID" && pair.Key != "No")
                        {
                            rowDataList.Add(pair.Value);
                        }
                    }

                    dataGridStudentCourses.Rows.Add(rowDataList.ToArray());

                }
            }
        }

        public void CustomClose()
        {
            comboSelectLecturer.SelectedIndex = 0;
            comboSelectUnits.SelectedIndex = 0;
            dataGridStudentCourses.DataSource = null;
            dataGridStudentCourses.Columns.Clear();
        }
    }
}
