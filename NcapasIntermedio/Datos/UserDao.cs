using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class UserDao:Conexion
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection()) 
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Users where LoginName=@user and Password=@pass";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) { return true; } else { return false; }
                }

            }

        }
    }
}
