using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Datos
{
    public abstract class Conexion
    {   
        private string connectionString;
        //private string connectionString = "Server=DESKTOP-VN9ML1G\\SQLEXPRESS;DataBase= MyCompany;Integrated Security=true";

        public void ConnectionToSql()
        {
            connectionString = "Server=DESKTOP-VN9ML1G\\SQLEXPRESS;DataBase= MyCompany;Integrated Security=true";
        }

        protected SqlConnection GetConnection(){
            ConnectionToSql();
            return new SqlConnection(connectionString);
        }
    }
}
