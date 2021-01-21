using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace UD18_Conexion_NET_DB
{
    class DB_Values
    {
        /*
         *  Clases para añadir, modificar y borrar tuplas de una tabla pasada por parametro.
         * 
         * 
         */

        public static void Insert_Value(string nombreBD, string nombreTabla, string codigoValor)
        {
            // método para insertar un string pasado por parámetro en una taba

            // conectamos a la base de datos
            SqlConnection conexion = DB_Connection.DB_Connexion_Open(nombreBD);

            // codigoSQL
            string cadena = "INSERT INTO " + nombreTabla + " VALUES " + codigoValor;

            try
            {
                // creamos el objeto con el codigo sql y la conexion
                SqlCommand comando = new SqlCommand(cadena, conexion);

                // ejecutamos el codigo sql en el objeto comando
                comando.ExecuteNonQuery();
                Console.WriteLine("Registro insertado con éxito");
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

        public static void Delete_Value_By_ID(string nombreBD, string nombreTabla, string nombrePK, string id)
        {
            // método para eliminar una tupla pasando por parámetro la pk de la tabla

            // conectamos a la base de datos
            SqlConnection conexion = DB_Connection.DB_Connexion_Open(nombreBD);

            // codigoSQL
            string cadena = "DELETE FROM " + nombreTabla + " WHERE " + nombrePK + " " + id;

            try
            {
                // creamos el objeto con el codigo sql y la conexion
                SqlCommand comando = new SqlCommand(cadena, conexion);

                // ejecutamos el codigo sql en el objeto comando
                comando.ExecuteNonQuery();
                Console.WriteLine("Registro eliminado con éxito");
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

        public static void Show_Value(string nombreBD, string nombreTabla, string valores, string condicion)
        {
            // método para hacer un select según la condición pasada por parámetro de una tabla específica
            // values == nombre de campos que quieres mostrar, puede ser * para todos
            // condicion == condiciones y subconsultas del codigo sql, puede ser "" para sin condiciones 

            // conectamos a la base de datos
            SqlConnection conexion = DB_Connection.DB_Connexion_Open(nombreBD);

            // codigoSQL
            string cadena = "SELECT " + valores + " FROM " + nombreTabla + " " + condicion;

            try
            {
                // creamos el objeto con el codigo sql y la conexion
                SqlCommand comando = new SqlCommand(cadena, conexion);

                // ejecutamos el codigo sql en el objeto comando
                comando.ExecuteNonQuery();
                // guardamos el contenido recibido de la consulta
                SqlDataReader registros = comando.ExecuteReader();
                // recorremos el resultado y printamos
                Boolean nombreColumna = true; // bolean para saber si es la primera columna del retorno de la consulta
                
                while (registros.Read())
                {
                    Console.Write("||");
                    if (nombreColumna == true) //si es la primera vez, printamos el nombre de las columnas
                    {
                        for (int x = 0; x < registros.FieldCount; x++)
                        {
                            Console.Write("  " + registros.GetName(x));
                            Console.Write("  ||");
                        }
                        nombreColumna = false; // asignem a fals
                        Console.WriteLine();
                        Console.Write("||");
                    }
                    for (int x = 0; x < registros.FieldCount; x++)
                    {
                        Console.Write("  " + registros[x]);
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
