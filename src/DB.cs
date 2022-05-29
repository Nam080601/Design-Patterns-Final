using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Design_Patterns_Final.src
{
    internal class DB
    {
        private static DB instance;
        private DB() { }
        public static DB Instance
        {
            get
            {
                if (instance == null)
                    instance = new DB();
                return DB.instance;
            }
            private set
            {
                DB.instance = value;
            }
        }
        private static string ConnectionString = "Data Source=.\\MAYCHU;Initial Catalog=MTK;User ID=sa;Password=123456";
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            DataTable data = new DataTable();
            {
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    string[] param = query.Split(' ');
                    int i = 0;
                    foreach (string item in param)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                conn.Close();
            }

            return data;
        }
    }
}
