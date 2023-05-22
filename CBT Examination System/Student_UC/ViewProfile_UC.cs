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
    public partial class ViewProfile_UC : UserControl
    {
        bool filled = false;

        public ViewProfile_UC()
        {
            InitializeComponent();
        }

        public void FillProfileDetails(string matricNo)
        {
            if (filled == true)
                return;

            DatabaseManager dbManager = new DatabaseManager();

            string query = "SELECT * FROM studentLoginDetails WHERE Matric_No = @matricNo";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@matricNo", matricNo);

            List<Dictionary<string, object>> result = dbManager.GetData(query, parameters);

            // If the result contains a single row, set the label text values
            if (result.Count == 1)
            {
                Dictionary<string, object> row = result[0];
                labelFullName.Text = row["Full_Name"].ToString();
                labelMatricNo.Text = row["Matric_No"].ToString();
                labelEmail.Text = row["Email"].ToString();
                labelPhoneNo.Text = row["Phone_No"].ToString();
                labelSession.Text = row["Session"].ToString();
                labelLevel.Text = row["Level"].ToString();
                labelDept.Text = row["Department"].ToString();

                // to prevent doing this everytime
                filled = true;
            }
        }

    }
}
