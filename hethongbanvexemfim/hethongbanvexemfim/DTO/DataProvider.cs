using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace hethongbanvexemfim.DTO
{
    public class DataProvider
    {
            private string connectionSTR = @"Data Source=LAPTOP-0VKU2PBT\SQLEXPRESS;Initial Catalog=HTQL_BANVEXEMFILM;Integrated Security=True";
        public DataTable ExcuteQuery(string query)
            {
                DataTable data = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionSTR)) ;
                {
                    SqlConnection connection = new SqlConnection(connectionSTR);

                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                  
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(data);

                    connection.Close();
                }
                return data;
            }
        
    }
}
