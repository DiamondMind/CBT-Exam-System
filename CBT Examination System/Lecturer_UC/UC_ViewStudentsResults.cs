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
    public partial class UC_ViewStudentsResults : UserControl
    {
        string _lecturerName;
        bool comboFilled = false;
        DatabaseManager databaseManager = new DatabaseManager();

        public UC_ViewStudentsResults()
        {
            InitializeComponent();
        }

        internal void ConstructTable(string lecturerName)
        {
            _lecturerName = lecturerName;

            string query = "SELECT * FROM studentsResults WHERE Lecturer_Name = @lecturerName";
            Dictionary<string, object> parameters = new Dictionary<string, object>();

            parameters.Add("@lecturerName", lecturerName);

            List<Dictionary<string, object>> data = databaseManager.GetData(query, parameters);

            // If the data is empty, display a message and return
            if (data.Count == 0)
            {
                MessageBox.Show("No results found. \n Your students are yet to complete an exam", "Empty Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataGridStudentResults.Columns.Clear();
            dataGridStudentResults.Rows.Clear();

            // Add the S/N column as the first column in the DataGridView
            DataGridViewTextBoxColumn snColumn = new DataGridViewTextBoxColumn();
            snColumn.Name = "S/N";
            snColumn.HeaderText = "S/N";
            dataGridStudentResults.Columns.Add(snColumn);

            // Create columns in the DataGridView control 
            foreach (string columnName in data[0].Keys)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.Name = columnName;
                column.HeaderText = columnName;
                dataGridStudentResults.Columns.Add(column);
            }

            // Populate the DataGridView control with data 
            int sn = 1;
            foreach (Dictionary<string, object> row in data)
            {
                List<object> rowDataList = new List<object>();
                rowDataList.Add(sn);
                sn++;

                foreach (KeyValuePair<string, object> pair in row)
                {
                    rowDataList.Add(pair.Value);
                }

                dataGridStudentResults.Rows.Add(rowDataList.ToArray());

            }

            if (comboFilled == false)
            {
                FillComboBox("Department".ToString(), comboSelectDept);
                FillComboBox("Course_Code".ToString(), comboSelectCourse);
                comboFilled = true;
            }

        }

        private void FillComboBox(string columnName, ComboBox comboBox)
        {
            string query = $"SELECT DISTINCT {columnName} FROM studentsResults WHERE Lecturer_Name = @lecturerName";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@lecturerName", _lecturerName);

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

        private void comboSelectDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDept = comboSelectDept.SelectedItem.ToString();

            if (selectedDept == "All") // if "All" is selected, retrieve all data
            {
                string query = "SELECT * FROM studentsResults WHERE Lecturer_Name = @lecturerName";
                Dictionary<string, object> parameters = new Dictionary<string, object>();

                parameters.Add("@lecturerName", _lecturerName);

                List<Dictionary<string, object>> data = databaseManager.GetData(query, parameters);

                // If the data is empty, display a message and return
                if (data.Count == 0)
                {
                    MessageBox.Show("No results found. \n Your students are yet to complete an exam", "Empty Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridStudentResults.Columns.Clear();
                dataGridStudentResults.Rows.Clear();

                // Add the S/N column as the first column in the DataGridView
                DataGridViewTextBoxColumn snColumn = new DataGridViewTextBoxColumn();
                snColumn.Name = "S/N";
                snColumn.HeaderText = "S/N";
                dataGridStudentResults.Columns.Add(snColumn);

                // Create columns in the DataGridView control 
                foreach (string columnName in data[0].Keys)
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.Name = columnName;
                    column.HeaderText = columnName;
                    dataGridStudentResults.Columns.Add(column);
                }

                // Populate the DataGridView control with data 
                int sn = 1;
                foreach (Dictionary<string, object> row in data)
                {
                    List<object> rowDataList = new List<object>();
                    rowDataList.Add(sn);
                    sn++;

                    foreach (KeyValuePair<string, object> pair in row)
                    {
                        rowDataList.Add(pair.Value);
                    }

                    dataGridStudentResults.Rows.Add(rowDataList.ToArray());

                }
            }
            else
            {
                string query = "SELECT * FROM studentsResults WHERE Lecturer_Name = @lecturerName AND Department = @selectedDept";
                Dictionary<string, object> parameters = new Dictionary<string, object>();

                parameters.Add("@lecturerName", _lecturerName);
                parameters.Add("@selectedDept", selectedDept);

                List<Dictionary<string, object>> data = databaseManager.GetData(query, parameters);

                // If the data is empty, display a message and return
                if (data.Count == 0)
                {
                    MessageBox.Show("No results found", "Empty Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridStudentResults.Columns.Clear();
                dataGridStudentResults.Rows.Clear();

                // Add the S/N column as the first column in the DataGridView
                DataGridViewTextBoxColumn snColumn = new DataGridViewTextBoxColumn();
                snColumn.Name = "S/N";
                snColumn.HeaderText = "S/N";
                dataGridStudentResults.Columns.Add(snColumn);

                // Create columns in the DataGridView control 
                foreach (string columnName in data[0].Keys)
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.Name = columnName;
                    column.HeaderText = columnName;
                    dataGridStudentResults.Columns.Add(column);
                }

                // Populate the DataGridView control with data 
                int sn = 1;
                foreach (Dictionary<string, object> row in data)
                {
                    List<object> rowDataList = new List<object>();
                    rowDataList.Add(sn);
                    sn++;

                    foreach (KeyValuePair<string, object> pair in row)
                    {
                        rowDataList.Add(pair.Value);
                    }

                    dataGridStudentResults.Rows.Add(rowDataList.ToArray());

                }
            }
        }

        private void comboSelectCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCourse = comboSelectCourse.SelectedItem.ToString();

            if (selectedCourse == "All") // if "All" is selected, retrieve all data
            {
                string query = "SELECT * FROM studentsResults WHERE Lecturer_Name = @lecturerName";
                Dictionary<string, object> parameters = new Dictionary<string, object>();

                parameters.Add("@lecturerName", _lecturerName);

                List<Dictionary<string, object>> data = databaseManager.GetData(query, parameters);

                // If the data is empty, display a message and return
                if (data.Count == 0)
                {
                    MessageBox.Show("No results found. \n Your students are yet to complete an exam", "Empty Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridStudentResults.Columns.Clear();
                dataGridStudentResults.Rows.Clear();

                // Add the S/N column as the first column in the DataGridView
                DataGridViewTextBoxColumn snColumn = new DataGridViewTextBoxColumn();
                snColumn.Name = "S/N";
                snColumn.HeaderText = "S/N";
                dataGridStudentResults.Columns.Add(snColumn);

                // Create columns in the DataGridView control 
                foreach (string columnName in data[0].Keys)
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.Name = columnName;
                    column.HeaderText = columnName;
                    dataGridStudentResults.Columns.Add(column);
                }

                // Populate the DataGridView control with data 
                int sn = 1;
                foreach (Dictionary<string, object> row in data)
                {
                    List<object> rowDataList = new List<object>();
                    rowDataList.Add(sn);
                    sn++;

                    foreach (KeyValuePair<string, object> pair in row)
                    {
                        rowDataList.Add(pair.Value);
                    }

                    dataGridStudentResults.Rows.Add(rowDataList.ToArray());

                }
            }
            else
            {
                string query = "SELECT * FROM studentsResults WHERE Lecturer_Name = @lecturerName AND Course_Code = @selectedCourse";
                Dictionary<string, object> parameters = new Dictionary<string, object>();

                parameters.Add("@lecturerName", _lecturerName);
                parameters.Add("@selectedCourse", selectedCourse);

                List<Dictionary<string, object>> data = databaseManager.GetData(query, parameters);

                // If the data is empty, display a message and return
                if (data.Count == 0)
                {
                    MessageBox.Show("No results found", "Empty Table", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridStudentResults.Columns.Clear();
                dataGridStudentResults.Rows.Clear();

                // Add the S/N column as the first column in the DataGridView
                DataGridViewTextBoxColumn snColumn = new DataGridViewTextBoxColumn();
                snColumn.Name = "S/N";
                snColumn.HeaderText = "S/N";
                dataGridStudentResults.Columns.Add(snColumn);

                // Create columns in the DataGridView control 
                foreach (string columnName in data[0].Keys)
                {
                    DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                    column.Name = columnName;
                    column.HeaderText = columnName;
                    dataGridStudentResults.Columns.Add(column);
                }

                // Populate the DataGridView control with data 
                int sn = 1;
                foreach (Dictionary<string, object> row in data)
                {
                    List<object> rowDataList = new List<object>();
                    rowDataList.Add(sn);
                    sn++;

                    foreach (KeyValuePair<string, object> pair in row)
                    {
                        rowDataList.Add(pair.Value);
                    }

                    dataGridStudentResults.Rows.Add(rowDataList.ToArray());

                }
            }
        }

    }
}
