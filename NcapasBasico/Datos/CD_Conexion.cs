using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient; //agregamos 
using System.Data; //agregamos 

namespace Datos
{
    class CD_Conexion
    {
        //Cadena conexion // Comentario de Dario : pongan el server que hicimos en la clase de SQL - la base de datos la crean con "SQL server magnament studio"
        private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-6U8Q54U\\SQLEXPRESS;DataBase= Practica;Integrated Security=true");
        //Abre conexion
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        //Cierra conexion
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
