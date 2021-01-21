using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace UD18_Conexion_NET_DB
{
    class DB_Table
    {
        /*
         *  Clase para crear y borrar tablas a las bases de datos pasadas por parámetros.
         * 
         * 
         */
        public static void Create_Table(string nombreBD, string nombreTabla, string columnas)
        {
            // método para crear una tabla.

            // establecemos la conexión con la BD creada
            SqlConnection conexion = DB_Connection.DB_Connexion_Open(nombreBD);

            // creamos el código SQL con el nombre de la tabla y los valor de columna pasados por parámetro
            string codigoSQL = "CREATE TABLE " + nombreTabla + "(" + columnas + ");";

            // ejecutamos el código sql
            try
            {
                SqlCommand comando = new SqlCommand(codigoSQL, conexion);
                comando.ExecuteNonQuery();
                Console.WriteLine("Tabla {0} creada con éxito", nombreTabla);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                // cerramos la conexión con la base de datos creada
                conexion.Close();
            }
        }
        public static void Delete_Table(string nombreBD, string nombreTabla)
        {
            // método para borrar una tabla.

            // establecemos la conexión con la BD creada
            SqlConnection conexion = DB_Connection.DB_Connexion_Open(nombreBD);

            // creamos el código SQL con el nombre de la tabla y los valor de columna pasados por parámetro
            string codigoSQL = "DROP TABLE " + nombreTabla;

            // ejecutamos el código sql
            try
            {
                SqlCommand comando = new SqlCommand(codigoSQL, conexion);
                comando.ExecuteNonQuery();
                Console.WriteLine("Tabla {0} eliminada con éxito", nombreTabla);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                // cerramos la conexión con la base de datos creada
                conexion.Close();
            }
        }
        public static void Show_Tables_Names(string nombreBD)
        {
            // método para mostrar todas las tablas de una base de datos pasado por parámetro.

            // establecemos la conexión con la BD creada
            SqlConnection conexion = DB_Connection.DB_Connexion_Open(nombreBD);

            try
            {
                // recogemos los nombres de las tablas en un objeto
                DataTable dt = conexion.GetSchema("Tables");
                Console.WriteLine("Tablas en la base de datos {0}: ", nombreBD);
                // por cada nombre en el objeto
                foreach (DataRow row in dt.Rows)
                {
                    // printamos
                    Console.WriteLine("   └── " + (string)row[2]);

                    // printamos las columnas de la tabla:
                    // asignamos el nombre de la tabla
                    string TableName = (string)row[2];
                    string[] restrictionsColumns = new string[4]; // creamos array para usar en la llamada al objeto DataTable
                    restrictionsColumns[2] = TableName; // asignamos el nombre de la tabla en el array
                    DataTable schemaColumns = conexion.GetSchema("Columns", restrictionsColumns); // creamos la conexion a la tabla
                    // recorremos las columnas y printamos
                    foreach (System.Data.DataRow rowColumn in schemaColumns.Rows)
                    {
                        Console.WriteLine("         └── " + (string)rowColumn[3]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                // cerramos la conexión con la base de datos creada
                conexion.Close();
            }
        }
        public static void Show_Table(string nombreBD, string nombreTabla)
        {
            // método para mostrar el contenido de una tabla.

            // establecemos la conexión con la BD creada
            SqlConnection conexion = DB_Connection.DB_Connexion_Open(nombreBD);

            try
            {
                // contador donde guardamos la cantidad de columnas para recorrer los valores luego
                int nombreColumnas = 0;

                // creamos array para usar en la llamada al objeto DataTable
                string[] restrictionsColumns = new string[4]; 
                restrictionsColumns[2] = nombreTabla; // asignamos el nombre de la tabla en el array

                // creamos la conexion a la tabla
                DataTable schemaColumns = conexion.GetSchema("Columns", restrictionsColumns);

                // recorremos las columnas y las guardamos en la lista
                Console.Write("||");
                foreach (System.Data.DataRow rowColumn in schemaColumns.Rows)
                {
                    // sumamos el numero de columnas
                    nombreColumnas++;
                    // imprimimos el nombre de la columna
                    Console.Write("  "+(string)rowColumn[3]);
                    Console.Write("  ||");
                }
                Console.WriteLine();

                // creamos el código SQL con el nombre de la tabla pasados por parámetro
                string codigoSQL = "SELECT * FROM " + nombreTabla;

                // ejecutamos el sql
                SqlCommand comando = new SqlCommand(codigoSQL, conexion);
                // guardamos el contenido recibido de la consulta
                SqlDataReader registros = comando.ExecuteReader();
                // recorremos el resultado y printamos
                while (registros.Read())
                {
                    Console.Write("||");
                    for (int x = 0; x < nombreColumnas; x++)
                    {
                        Console.Write("  " + registros[x].ToString());
                        Console.Write("  ||");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                // cerramos la conexión con la base de datos creada
                conexion.Close();
            }
        }
    }
}
