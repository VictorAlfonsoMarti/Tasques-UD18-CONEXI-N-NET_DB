using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace UD18_Conexion_NET_DB
{
    class DB_Database
    {
        /*
         *  Clase para crear y borrar bases de datos.
         * 
         * 
         */
        public static void DB_CreateDatabase(string BD)
        {
            // creamos una base de datos nueva con el nombre pasado por parámetro
            SqlConnection conexion = DB_Connection.Server_Connexion_Open(); // abrimos la conexion al servidor
            try
            {
                    string codiSQL = "CREATE DATABASE " + BD; // codigo sql con el string del nombre
                    SqlCommand consultaSQL = new SqlCommand(codiSQL, conexion); //guardamos la consulta y la conexion

                    consultaSQL.ExecuteNonQuery(); // ejecutamos la conexion
                    Console.WriteLine("La base de datos {0} ha sido creada", BD);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                conexion.Close();
            }
        }
        public static void DB_DeleteDatabase(string BD)
        {
            // borramos una base de datos con el nombre pasado por parámetro
            SqlConnection conexion = DB_Connection.Server_Connexion_Open(); // abrimos la conexion al servidor
            try
            {
                string codiSQL = "DROP DATABASE " + BD; // codigo sql con el string del nombre
                SqlCommand consultaSQL = new SqlCommand(codiSQL, conexion); //guardamos la consulta y la conexion

                consultaSQL.ExecuteNonQuery(); // ejecutamos la conexion
                Console.WriteLine("La base de datos {0} ha sido borrada", BD);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
