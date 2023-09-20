using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Datos
{
    public abstract class Conexion
    {
        private readonly string connectionString;

        public ConnectionToSql(){
            connectionString = "Server=DESKTOP-6U8Q54U\\SQLEXPRESS;DataBase= Practica;Integrated Security=true";
        }

        protected SqlConnection GetConnection(){
            return new SqlConnection(connectionString);
        }
    }
}
