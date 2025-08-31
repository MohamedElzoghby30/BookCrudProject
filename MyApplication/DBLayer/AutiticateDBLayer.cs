using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyApplication
{
    public  class AutiticateDBLayer
    {

        private static readonly string con = ConfigurationManager.ConnectionStrings["BookDB"].ConnectionString;
      
        public static bool Login(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM AdminApp WHERE Email = @email AND Passworrd = @pass", connection))
                {
                    sqlCommand.Parameters.AddWithValue("@email", username);
                    sqlCommand.Parameters.AddWithValue("@pass", password);

                    connection.Open();
                    var result = sqlCommand.ExecuteScalar();
                    return result != null ? true : false;
                }
            }

        }
    }
}