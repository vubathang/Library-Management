using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccessData
    {
        public AccessData() { }
        SqlDataAdapter adapter;
        SqlCommand command;
        //View 
        public DataTable GetTable(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = Environment.GetSqlConnection())
            {
                connection.Open();
                adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        // Add && Edit && Delete
        public void Command(string query)
        {
            using (SqlConnection connection = Environment.GetSqlConnection()) 
            { 
                connection.Open();
                command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
