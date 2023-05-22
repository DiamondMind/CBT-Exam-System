using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CBT_Examination_System
{

    public class DatabaseManager
    {
        private readonly string connectionString = "Data Source=desktop-mtq1ug7\\sqlexpress;Initial Catalog=CBTExamSystem;Integrated Security=True";     //"data source = desktop-mtq1ug7\\sqlexpress;integrated security = True";  // server name

        public List<Dictionary<string, object>> GetData(string query, Dictionary<string, object> parameters = null)
        {
            List<Dictionary<string, object>> result = new List<Dictionary<string, object>>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                }

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Dictionary<string, object> row = new Dictionary<string, object>();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row.Add(reader.GetName(i), reader.GetValue(i));
                        }

                        result.Add(row);
                    }
                }
            }

            return result;
        }

        public int UpdateData(string query, Dictionary<string, object> parameters = null)
        {
            int rowsAffected = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                if (parameters != null)
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                    }
                }

                connection.Open();

                rowsAffected = command.ExecuteNonQuery();
            }

            return rowsAffected;
        }
    }

}
