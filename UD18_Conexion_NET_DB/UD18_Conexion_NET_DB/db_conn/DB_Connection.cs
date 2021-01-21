using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace UD18_Conexion_NET_DB
{
    class DB_Connection
    {
        /*
         *  Clase para cerrar y abrir conexion con  el servidor y la base de datos.
         * 
         * 
         */
        public static SqlConnection DB_Connexion_Open(string BD)
        {
            // establece conexion con la base de datos pasada por parametro.
            SqlConnection conexion = new SqlConnection("Data Source=192.168.1.205;Initial Catalog="+BD+";Persist Security Info=True;User ID=victor;Password=victor");
            try
            {
                conexion.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return conexion;
        }
        public static SqlConnection Server_Connexion_Open()
        {
            // establece conexion con el servidor, sin base de datos.
            SqlConnection conexion = new SqlConnection("Data Source=192.168.1.205;Persist Security Info=True;User ID=victor;Password=victor");
            try
            {
                conexion.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return conexion;
        }
    }
}
