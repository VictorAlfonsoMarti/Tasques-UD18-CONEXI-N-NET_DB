using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace UD18_Conexion_NET_DB
{
    class Ejercicios
    {
        public static void Ejercicio_1()
        {

            //nombre de la base de datos
            string nombreBD = "UD18_EJERCICIO_1";


            //// creamos BD UD18_EJERCICIO_1
            DB_Database.DB_CreateDatabase(nombreBD);

            // creamos las tablas deseadas
            string nombreTabla = "FABRICANTES";
            string columnas = "Codigo INT PRIMARY KEY IDENTITY(1,1), Nombre NVARCHAR(100)";
            DB_Table.Create_Table(nombreBD, nombreTabla, columnas);

            string nombreTabla2 = "ARTICULOS";
            string columnas2 = "Codigo INT PRIMARY KEY IDENTITY(1,1), Nombre NVARCHAR(100), Precio INT, Fabricante INT FOREIGN KEY REFERENCES FABRICANTES(Codigo) ON DELETE SET NULL ON UPDATE CASCADE";
            DB_Table.Create_Table(nombreBD, nombreTabla2, columnas2);

            // mostramos las tablas de creadas
            DB_Table.Show_Tables_Names(nombreBD);

            // insertamos valores en las tablas
            // tabla "FABRICANTES"
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Fabricante 1')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Fabricante 2')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Fabricante 3')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Fabricante 4')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Fabricante 5')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Fabricante 6')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Fabricante 7')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Fabricante 8')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Fabricante 9')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Fabricante 10')");

            //tabla "ARTICULOS"
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Articulo 1', 24, 4)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Articulo 2', 10, 3)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Articulo 3', 45, 1)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Articulo 4', 76, 10)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Articulo 5', 123, 9)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Articulo 6', 276, 6)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Articulo 7', 81, 7)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Articulo 8', 102, 8)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Articulo 9', 518, 5)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Articulo 10', 21, 2)");


            // mostramos los registros creados por cada tabla
            Console.WriteLine("Tabla :" + nombreTabla);
            DB_Table.Show_Table(nombreBD, nombreTabla);
            Console.WriteLine("Tabla :" + nombreTabla2);
            DB_Table.Show_Table(nombreBD, nombreTabla2);

            // mostramos valores especificos
            //DB_Values.Show_Value(nombreBD, nombreTabla2, "nombre, precio", "WHERE Fabricante='2'");

        }

        public static void Ejercicio_2()
        {

            //nombre de la base de datos
            string nombreBD = "UD18_EJERCICIO_2";


            //// creamos BD UD18_EJERCICIO_2
            DB_Database.DB_CreateDatabase(nombreBD);

            // creamos las tablas deseadas
            string nombreTabla = "DEPARTAMENTOS";
            string columnas = "Codigo INT PRIMARY KEY, Nombre NVARCHAR(100), Presupuesto INT";
            DB_Table.Create_Table(nombreBD, nombreTabla, columnas);

            string nombreTabla2 = "EMPLEADOS";
            string columnas2 = "DNI VARCHAR(8) PRIMARY KEY, Nombre NVARCHAR(100), Apellidos NVARCHAR(100), Departamento INT FOREIGN KEY REFERENCES DEPARTAMENTOS(Codigo) ON DELETE SET NULL ON UPDATE CASCADE";
            DB_Table.Create_Table(nombreBD, nombreTabla2, columnas2);

            // mostramos las tablas de creadas
            DB_Table.Show_Tables_Names(nombreBD);

            // insertamos valores en las tablas
            // tabla "DEPARTAMENTOS"
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(1, 'Departamento 1', 20000)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(2, 'Departamento 2', 25000)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(3, 'Departamento 3', 42000)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(4, 'Departamento 4', 12000)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(5, 'Departamento 5', 5000)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(6, 'Departamento 6', 200)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(7, 'Departamento 7', 86000)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(8, 'Departamento 8', 250000)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(9, 'Departamento 9', 1000)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(10, 'Departamento 10', 1430)");


            //tabla "EMPLEADOS"
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0000001A', 'Nombre 1', 'Apellido 1', 1)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0000002B', 'Nombre 2', 'Apellido 2', 2)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0000003C', 'Nombre 3', 'Apellido 3', 3)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0000004D', 'Nombre 4', 'Apellido 4', 4)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0000005E', 'Nombre 5', 'Apellido 5', 5)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0000006F', 'Nombre 6', 'Apellido 6', 6)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0000007G', 'Nombre 7', 'Apellido 7', 7)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0000008H', 'Nombre 8', 'Apellido 8', 8)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0000009I', 'Nombre 9', 'Apellido 9', 9)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0000010J', 'Nombre 10', 'Apellido 10', 1)");


            // mostramos los registros creados por cada tabla
            Console.WriteLine("Tabla :" + nombreTabla);
            DB_Table.Show_Table(nombreBD, nombreTabla);
            Console.WriteLine("Tabla :" + nombreTabla2);
            DB_Table.Show_Table(nombreBD, nombreTabla2);

        }

        public static void Ejercicio_3()
        {
            //nombre de la base de datos
            string nombreBD = "UD18_EJERCICIO_3";

            //// creamos BD UD18_EJERCICIO_3
            DB_Database.DB_CreateDatabase(nombreBD);

            // creamos las tablas deseadas
            string nombreTabla = "ALMACENES";
            string columnas = "Codigo INT PRIMARY KEY IDENTITY(1,1), Lugar NVARCHAR(100), Capacidad INT";
            DB_Table.Create_Table(nombreBD, nombreTabla, columnas);

            string nombreTabla2 = "CAJAS";
            string columnas2 = "NumReferencia CHAR(5) PRIMARY KEY, Contenido NVARCHAR(100), Valor INT, Almacen INT FOREIGN KEY REFERENCES ALMACENES(Codigo) ON DELETE SET NULL ON UPDATE CASCADE";
            DB_Table.Create_Table(nombreBD, nombreTabla2, columnas2);

            // mostramos las tablas de creadas
            DB_Table.Show_Tables_Names(nombreBD);

            // insertamos valores en las tablas
            // tabla "ALMACENES"
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Reus', 10)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Cambrils', 5)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Tarragona', 12)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Valls', 21)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Barcelona', 100)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Lleida', 50)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Girona', 40)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Madrid', 90)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Paris', 120)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Londres', 5)");


            //tabla "CAJAS"
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0001A', 'Contenido 1', 12, 1)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0002B', 'Contenido 2', 56, 2)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0003C', 'Contenido 3', 2, 3)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0004D', 'Contenido 4', 97, 4)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0005E', 'Contenido 5', 321, 5)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0006F', 'Contenido 6', 65, 6)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0007G', 'Contenido 7', 35, 7)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0008H', 'Contenido 8', 98, 8)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0009I', 'Contenido 9', 21, 9)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0010J', 'Contenido 10', 49, 10)");


            // mostramos los registros creados por cada tabla
            Console.WriteLine("Tabla :" + nombreTabla);
            DB_Table.Show_Table(nombreBD, nombreTabla);
            Console.WriteLine("Tabla :" + nombreTabla2);
            DB_Table.Show_Table(nombreBD, nombreTabla2);

        }

        public static void Ejercicio_4()
        {
            //nombre de la base de datos
            string nombreBD = "UD18_EJERCICIO_4";

            //// creamos BD UD18_EJERCICIO_4
            DB_Database.DB_CreateDatabase(nombreBD);

            // creamos las tablas deseadas
            string nombreTabla = "PELICULAS";
            string columnas = "Codigo INT PRIMARY KEY IDENTITY(1,1), Nombre NVARCHAR(100), CalificacionEdad INT";
            DB_Table.Create_Table(nombreBD, nombreTabla, columnas);

            string nombreTabla2 = "SALAS";
            string columnas2 = "Codigo INT PRIMARY KEY IDENTITY(1,1), Nombre NVARCHAR(100), Pelicula INT FOREIGN KEY REFERENCES PELICULAS(Codigo) ON DELETE SET NULL ON UPDATE CASCADE";
            DB_Table.Create_Table(nombreBD, nombreTabla2, columnas2);

            // mostramos las tablas de creadas
            DB_Table.Show_Tables_Names(nombreBD);

            // insertamos valores en las tablas
            // tabla "PELICULAS"
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Reus La Película', NULL)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Cambrils La Película', 13)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Tarragona La Película', 13)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Valls La Película', NULL)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Barcelona La Película', 18)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Lleida La Película', 18)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Girona La Película', 16)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Madrid La Película', 13)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Paris La Película', NULL)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Londres La Película', 18)");


            //tabla "SALAS"
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Sala 1', 1)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Sala 2', 2)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Sala 3', 3)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Sala 4', 4)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Sala 5', 5)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Sala 6', 6)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Sala 7', 7)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Sala 8', 8)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Sala 9', 9)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Sala 10', 10)");


            // mostramos los registros creados por cada tabla
            Console.WriteLine("Tabla :" + nombreTabla);
            DB_Table.Show_Table(nombreBD, nombreTabla);
            Console.WriteLine("Tabla :" + nombreTabla2);
            DB_Table.Show_Table(nombreBD, nombreTabla2);

        }

        public static void Ejercicio_5()
        {
            //nombre de la base de datos
            string nombreBD = "UD18_EJERCICIO_5";

            //// creamos BD UD18_EJERCICIO_5
            DB_Database.DB_CreateDatabase(nombreBD);

            // creamos las tablas deseadas
            string nombreTabla = "DESPACHOS";
            string columnas = "Numero INT PRIMARY KEY, Capacidad INT";
            DB_Table.Create_Table(nombreBD, nombreTabla, columnas);

            string nombreTabla2 = "DIRECTORES";
            string columnas2 = "DNI VARCHAR(8) PRIMARY KEY, NomApels NVARCHAR(255), DNIJefe VARCHAR(8) FOREIGN KEY REFERENCES DIRECTORES(DNI), Despacho INT FOREIGN KEY REFERENCES DESPACHOS(Numero)";
            DB_Table.Create_Table(nombreBD, nombreTabla2, columnas2);

            // mostramos las tablas de creadas
            DB_Table.Show_Tables_Names(nombreBD);

            // insertamos valores en las tablas
            // tabla "DESPACHOS"
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(1, 3)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(2, 6)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(3, 8)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(4, 5)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(5, 7)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(6, 9)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(7, 2)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(8, 8)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(9, 7)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(10, 3)");

            //tabla "DIRECTORES"
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0000001A', 'Nombre 1', NULL, 4)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0000002B', 'Nombre 2', '0000001A', 2)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0000003C', 'Nombre 3', '0000002B', 1)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0000004D', 'Nombre 4', '0000001A', 6)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0000005E', 'Nombre 5', '0000004D', 5)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0000006F', 'Nombre 6', NULL, 1)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0000007G', 'Nombre 7', NULL, 5)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0000008H', 'Nombre 8', '0000006F', 8)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0000009I', 'Nombre 9', '0000002B', 7)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0000001J', 'Nombre 10', '0000001A', 5)");

            // mostramos los registros creados por cada tabla
            Console.WriteLine("Tabla :" + nombreTabla);
            DB_Table.Show_Table(nombreBD, nombreTabla);
            Console.WriteLine("Tabla :" + nombreTabla2);
            DB_Table.Show_Table(nombreBD, nombreTabla2);
        }

        public static void Ejercicio_6()
        {
            //nombre de la base de datos
            string nombreBD = "UD18_EJERCICIO_6";

            //// creamos BD UD18_EJERCICIO_6
            DB_Database.DB_CreateDatabase(nombreBD);

            // creamos las tablas deseadas
            string nombreTabla = "PIEZAS";
            string columnas = "Codigo INT PRIMARY KEY IDENTITY(1,1), Nombre NVARCHAR(100)";
            DB_Table.Create_Table(nombreBD, nombreTabla, columnas);

            string nombreTabla2 = "PROVEEDORES";
            string columnas2 = "Id CHAR(4) PRIMARY KEY NOT NULL, Nombre NVARCHAR(100)";
            DB_Table.Create_Table(nombreBD, nombreTabla2, columnas2);

            string nombreTabla3 = "SUMINISTRA";
            string columnas3 = "CodigoPieza INT FOREIGN KEY REFERENCES Piezas(Codigo) ON DELETE NO ACTION ON UPDATE CASCADE, IdProveedor CHAR(4) FOREIGN KEY REFERENCES Proveedores(Id) ON DELETE NO ACTION ON UPDATE CASCADE, Precio INT, CONSTRAINT PK_Suministra PRIMARY KEY(CodigoPieza, IdProveedor)";
            DB_Table.Create_Table(nombreBD, nombreTabla3, columnas3);

            // mostramos las tablas de creadas
            DB_Table.Show_Tables_Names(nombreBD);

            // insertamos valores en las tablas
            // tabla "PIEZAS"
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Pieza1')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Pieza2')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Pieza3')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Pieza4')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Pieza5')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Pieza6')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Pieza7')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Pieza8')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Pieza9')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Pieza10')");


            //tabla "PROVEEDORES"
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"(1, 'Proveedor 1')");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"(2, 'Proveedor 2')");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"(3, 'Proveedor 3')");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"(4, 'Proveedor 4')");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"(5, 'Proveedor 5')");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"(6, 'Proveedor 6')");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"(7, 'Proveedor 7')");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"(8, 'Proveedor 8')");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"(9, 'Proveedor 9')");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"(10, 'Proveedor 10')");


            //tabla "SUMINISTRA"
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"(10, 1, 101)");
	        DB_Values.Insert_Value(nombreBD, nombreTabla3, @"(9, 2, 102)");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"(8, 3, 103)");
	        DB_Values.Insert_Value(nombreBD, nombreTabla3, @"(7, 4, 104)");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"(6, 5, 105)");
	        DB_Values.Insert_Value(nombreBD, nombreTabla3, @"(5, 6, 106)");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"(4, 7, 107)");
	        DB_Values.Insert_Value(nombreBD, nombreTabla3, @"(3, 8, 108)");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"(2, 9, 109)");
	        DB_Values.Insert_Value(nombreBD, nombreTabla3, @"(1, 10, 110)");

            // mostramos los registros creados por cada tabla
            Console.WriteLine("Tabla :" + nombreTabla);
            DB_Table.Show_Table(nombreBD, nombreTabla);
            Console.WriteLine("Tabla :" + nombreTabla2);
            DB_Table.Show_Table(nombreBD, nombreTabla2);
            Console.WriteLine("Tabla :" + nombreTabla3);
            DB_Table.Show_Table(nombreBD, nombreTabla3);
        }

        public static void Ejercicio_7()
        {
            //nombre de la base de datos
            string nombreBD = "UD18_EJERCICIO_7";

            //// creamos BD UD18_EJERCICIO_7
            DB_Database.DB_CreateDatabase(nombreBD);

            // creamos las tablas deseadas
            string nombreTabla = "CIENTIFICOS";
            string columnas = "DNI VARCHAR(8) PRIMARY KEY, NomApels NVARCHAR(255)";
            DB_Table.Create_Table(nombreBD, nombreTabla, columnas);

            string nombreTabla2 = "PROYECTO";
            string columnas2 = "Id CHAR(4) PRIMARY KEY, Nombre NVARCHAR(255), Horas INT";
            DB_Table.Create_Table(nombreBD, nombreTabla2, columnas2);

            string nombreTabla3 = "ASIGNADO_A";
            string columnas3 = "Cientifico VARCHAR(8) FOREIGN KEY REFERENCES Cientificos(DNI) ON DELETE NO ACTION ON UPDATE CASCADE, Proyecto CHAR(4) FOREIGN KEY REFERENCES Proyecto(Id) ON DELETE NO ACTION ON UPDATE CASCADE, CONSTRAINT PK_Asignado_a PRIMARY KEY(Cientifico, Proyecto)";
            DB_Table.Create_Table(nombreBD, nombreTabla3, columnas3);

            // mostramos las tablas de creadas
            DB_Table.Show_Tables_Names(nombreBD);

            // insertamos valores en las tablas
            // tabla "CIENTIFICOS"
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('10000000', 'Menganito 1')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('20000000', 'Menganito 2')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('30000000', 'Menganito 3')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('40000000', 'Menganito 4')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('50000000', 'Menganito 5')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('60000000', 'Menganito 6')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('70000000', 'Menganito 7')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('80000000', 'Menganito 8')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('90000000', 'Menganito 9')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('11000000', 'Menganito 10')");


            //tabla "PROYECTO"
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0001', 'Proyecto X', 20)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0002', 'Proyecto Y', 21)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0003', 'Proyecto Z', 22)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0004', 'Proyecto A', 23)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0005', 'Proyecto B', 24)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0006', 'Proyecto C', 25)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0007', 'Proyecto D', 26)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0008', 'Proyecto E', 27)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0009', 'Proyecto H', 28)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('0010', 'Proyecto K', 29)");


            //tabla "ASIGNADO_A"
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"('60000000', '0001')");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"('50000000', '0002')");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"('30000000', '0003')");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"('20000000', '0004')");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"('10000000', '0005')");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"('40000000', '0006')");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"('70000000', '0007')");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"('80000000', '0008')");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"('90000000', '0009')");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"('11000000', '0010')");

            // mostramos los registros creados por cada tabla
            Console.WriteLine("Tabla :" + nombreTabla);
            DB_Table.Show_Table(nombreBD, nombreTabla);
            Console.WriteLine("Tabla :" + nombreTabla2);
            DB_Table.Show_Table(nombreBD, nombreTabla2);
            Console.WriteLine("Tabla :" + nombreTabla3);
            DB_Table.Show_Table(nombreBD, nombreTabla3);
        }

        public static void Ejercicio_8()
        {
            //nombre de la base de datos
            string nombreBD = "UD18_EJERCICIO_8";

            //// creamos BD UD18_EJERCICIO_8
            DB_Database.DB_CreateDatabase(nombreBD);

            // creamos las tablas deseadas
            string nombreTabla = "PRODUCTOS";
            string columnas = "	Codigo INT PRIMARY KEY IDENTITY(1,1),Nombre NVARCHAR(100), Precio INT";
            DB_Table.Create_Table(nombreBD, nombreTabla, columnas);

            string nombreTabla2 = "CAJEROS";
            string columnas2 = "Codigo INT PRIMARY KEY IDENTITY(1,1), NomApels NVARCHAR(255)";
            DB_Table.Create_Table(nombreBD, nombreTabla2, columnas2);

            string nombreTabla3 = "MAQUINAS_REGISTRADORAS";
            string columnas3 = "Codigo INT PRIMARY KEY IDENTITY(1,1), Piso INT";
            DB_Table.Create_Table(nombreBD, nombreTabla3, columnas3);

            string nombreTabla4 = "VENTA";
            string columnas4 = "Cajero INT FOREIGN KEY REFERENCES Cajeros(Codigo), Maquina INT FOREIGN KEY REFERENCES Maquinas_Registradoras(Codigo), Producto INT FOREIGN KEY REFERENCES Productos(Codigo), CONSTRAINT PK_Venta PRIMARY KEY(Cajero, Maquina, Producto)";
            DB_Table.Create_Table(nombreBD, nombreTabla4, columnas4);

            // mostramos las tablas de creadas
            DB_Table.Show_Tables_Names(nombreBD);

            // insertamos valores en las tablas
            // tabla "PRODUCTOS"
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Producto 1', 31)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Producto 2', 32)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Producto 3', 33)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Producto 4', 34)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Producto 5', 35)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Producto 6', 36)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Producto 7', 37)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Producto 8', 38)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Producto 9', 39)");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"('Producto 10', 40)");



            //tabla "CAJEROS"
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Cajero 1')");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Cajero 2')");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Cajero 3')");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Cajero 4')");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Cajero 5')");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Cajero 6')");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Cajero 7')");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Cajero 8')");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Cajero 9')");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('Cajero 10')");


            //tabla "MAQUINAS_REGISTRADORAS"
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"(41)");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"(28)");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"(47)");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"(65)");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"(32)");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"(54)");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"(2)");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"(43)");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"(60)");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"(1)");

            //tabla "VENTA"
            DB_Values.Insert_Value(nombreBD, nombreTabla4, @"(5,3,1)");
            DB_Values.Insert_Value(nombreBD, nombreTabla4, @"(4,5,2)");
            DB_Values.Insert_Value(nombreBD, nombreTabla4, @"(3,6,3)");
            DB_Values.Insert_Value(nombreBD, nombreTabla4, @"(2,8,10)");
            DB_Values.Insert_Value(nombreBD, nombreTabla4, @"(1,7,9)");
            DB_Values.Insert_Value(nombreBD, nombreTabla4, @"(10,9,2)");
            DB_Values.Insert_Value(nombreBD, nombreTabla4, @"(9,10,8)");
            DB_Values.Insert_Value(nombreBD, nombreTabla4, @"(8,1,7)");
            DB_Values.Insert_Value(nombreBD, nombreTabla4, @"(7,2,6)");
            DB_Values.Insert_Value(nombreBD, nombreTabla4, @"(6,4,2)");


            // mostramos los registros creados por cada tabla
            Console.WriteLine("Tabla :" + nombreTabla);
            DB_Table.Show_Table(nombreBD, nombreTabla);
            Console.WriteLine("Tabla :" + nombreTabla2);
            DB_Table.Show_Table(nombreBD, nombreTabla2);
            Console.WriteLine("Tabla :" + nombreTabla3);
            DB_Table.Show_Table(nombreBD, nombreTabla3);
            Console.WriteLine("Tabla :" + nombreTabla4);
            DB_Table.Show_Table(nombreBD, nombreTabla4);
        }

        public static void Ejercicio_9()
        {
            //nombre de la base de datos
            string nombreBD = "UD18_EJERCICIO_9";

            //// creamos BD UD18_EJERCICIO_9
            DB_Database.DB_CreateDatabase(nombreBD);

            // creamos las tablas deseadas
            string nombreTabla = "FACULTAD";
            string columnas = "	Codigo INT PRIMARY KEY, Nombre NVARCHAR(100)";
            DB_Table.Create_Table(nombreBD, nombreTabla, columnas);

            string nombreTabla2 = "INVESTIGADORES";
            string columnas2 = "DNI VARCHAR(8) PRIMARY KEY, NomApels NVARCHAR(255),	Facultad INT FOREIGN KEY REFERENCES Facultad(Codigo) ON DELETE NO ACTION ON UPDATE CASCADE";
            DB_Table.Create_Table(nombreBD, nombreTabla2, columnas2);

            string nombreTabla3 = "EQUIPOS";
            string columnas3 = "	NumSerie CHAR(4) PRIMARY KEY, Nombre NVARCHAR(100),	Facultad INT FOREIGN KEY REFERENCES Facultad(Codigo) ON DELETE NO ACTION ON UPDATE CASCADE";
            DB_Table.Create_Table(nombreBD, nombreTabla3, columnas3);

            string nombreTabla4 = "RESERVA";
            string columnas4 = "DNI VARCHAR(8) FOREIGN KEY REFERENCES Investigadores(DNI) ON DELETE NO ACTION ON UPDATE NO ACTION, NumSerie CHAR(4) FOREIGN KEY REFERENCES Equipos(NumSerie) ON DELETE NO ACTION ON UPDATE NO ACTION, Comienzo DATETIME, Fin DATETIME, CONSTRAINT PK_Reserva PRIMARY KEY(DNI, NumSerie)";
            DB_Table.Create_Table(nombreBD, nombreTabla4, columnas4);

            // mostramos las tablas de creadas
            DB_Table.Show_Tables_Names(nombreBD);

            // insertamos valores en las tablas
            // tabla "FACULTAD"
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(1, 'Facutlad 1')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(2, 'Facutlad 2')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(3, 'Facutlad 3')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(4, 'Facutlad 4')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(5, 'Facutlad 5')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(6, 'Facutlad 6')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(7, 'Facutlad 7')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(8, 'Facutlad 8')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(9, 'Facutlad 9')");
            DB_Values.Insert_Value(nombreBD, nombreTabla, @"(10, 'Facutlad 10')");


            //tabla "INVESTIGADORES"
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('00000001', 'Señor X', 1)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('00000002', 'Señor Y', 2)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('00000003', 'Señor Z', 3)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('00000004', 'Señor A', 4)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('00000005', 'Señor B', 5)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('00000006', 'Señor C', 6)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('00000007', 'Señor D', 7)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('00000008', 'Señor E', 8)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('00000009', 'Señor X', 9)");
            DB_Values.Insert_Value(nombreBD, nombreTabla2, @"('00000010', 'Señor Rosa', 10)");



            //tabla "EQUIPOS"
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"('000A', 'Equipo 1', 10)");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"('000B', 'Equipo 2', 9)");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"('000C', 'Equipo 3', 8)");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"('000D', 'Equipo 4', 7)");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"('000E', 'Equipo 5', 6)");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"('000F', 'Equipo 6', 5)");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"('000G', 'Equipo 7', 4)");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"('000H', 'Equipo 8', 3)");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"('000I', 'Equipo 9', 2)");
            DB_Values.Insert_Value(nombreBD, nombreTabla3, @"('000J', 'Equipo 10', 1)");

            //tabla "RESERVA"
            DB_Values.Insert_Value(nombreBD, nombreTabla4, @"('00000001','000J', '2001-01-01','2001-02-09')");
            DB_Values.Insert_Value(nombreBD, nombreTabla4, @"('00000002','000I', '2002-02-02','2002-03-08')");
            DB_Values.Insert_Value(nombreBD, nombreTabla4, @"('00000003','000H', '2003-03-03','2003-04-07')");
            DB_Values.Insert_Value(nombreBD, nombreTabla4, @"('00000004','000G', '2004-04-04','2004-05-06')");
            DB_Values.Insert_Value(nombreBD, nombreTabla4, @"('00000006','000E', '2006-06-06','2006-07-04')");
            DB_Values.Insert_Value(nombreBD, nombreTabla4, @"('00000007','000D', '2007-07-07','2007-08-03')");
            DB_Values.Insert_Value(nombreBD, nombreTabla4, @"('00000008','000C', '2008-08-08','2008-09-02')");
            DB_Values.Insert_Value(nombreBD, nombreTabla4, @"('00000009','000B', '2009-09-09','2009-01-01')");
            DB_Values.Insert_Value(nombreBD, nombreTabla4, @"('00000010','000A', '2010-10-10','2011-11-11')");


            // mostramos los registros creados por cada tabla
            Console.WriteLine("Tabla :" + nombreTabla);
            DB_Table.Show_Table(nombreBD, nombreTabla);
            Console.WriteLine("Tabla :" + nombreTabla2);
            DB_Table.Show_Table(nombreBD, nombreTabla2);
            Console.WriteLine("Tabla :" + nombreTabla3);
            DB_Table.Show_Table(nombreBD, nombreTabla3);
            Console.WriteLine("Tabla :" + nombreTabla4);
            DB_Table.Show_Table(nombreBD, nombreTabla4);
        }
    }
}
