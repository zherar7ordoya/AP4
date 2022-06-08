using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
   public class Metodos
    {
       
        SqlDataAdapter Da;
        
        public DataSet ArmarDataSet()
        {
            DataSet Ds = new DataSet();
            //DESDE ADO.NET SE PUEDE INSTANCIAR UN DATATABLE FUERA DE UN DATASET
            DataTable Tabla = new DataTable("Persona");

            //LAS COLUMNAS SE PUEDEN INSTANCIAR FUERA DEL DATATABLE Y AGREGAR LUEGO
            DataColumn Clave = new DataColumn();
            Clave.ColumnName = "Codigo_Persona";
            Clave.DataType = typeof(Int32);
            Clave.AutoIncrement = true;
            Clave.AutoIncrementSeed = 1;
            Clave.AutoIncrementStep = 1;
            Clave.AllowDBNull = false;
            Clave.Unique = true;

            Tabla.Columns.Add(Clave);

            //Determino cual es la clave de la tabla
            Tabla.PrimaryKey = new DataColumn[] { Clave };


            //O SE PUEDEN AGREGAR DIRECTAMENTE usando el constructor
            Tabla.Columns.Add("Nombre", typeof(System.String));
            Tabla.Columns.Add("Apellido", typeof(System.String));
            Tabla.Columns.Add("FechaNac", typeof(System.DateTime));
            Tabla.Columns.Add("Persona_Pais_Id", typeof(System.Int32));
            //CLAVE FORANEA DE LA TABLA PAIS

            //SE PODRIA TRABAJAR DIRECTAMENTE CON EL DATATABLE, PERO LO AGREGAMOS AL DATASET PORQUE QUEREMOS
            //AGREGAR OTRA TABLA RELACIONADA
            Ds.Tables.Add(Tabla);
         
            //UNA TABLA SE PUEDE INSTANCIAR FUERA Y LUEGO AGREGAR
            //AGREGAMOS OTRA TABLA PARA LOS PAISES
            Ds.Tables.Add("Pais");
            //UNA TABLA TAMBIEN SE PUEDE CREAR Y AGREGAR DIRECTAMENTE EN LA MISMA LINEA
            //AGREGAMOS LAS COLUMNAS PARA LA TABLA PAIS
            var _with1 = Ds.Tables["Pais"].Columns;
            _with1.Add("Codigo_Pais", typeof(System.Int32));
            _with1.Add("Pais_Nombre", typeof(System.String));

            //GENERAMOS LA CLAVE PRIMARIA PARA LA TABLA PAIS
            //LA CLAVE PRIMARIA ES UN ARRAY DE DATACOLUMN (PORQUE PODRIA SER UNA CLAVE COMPUESTA)
            //EN LA MISMA LINEA SE CREA EL ARRAY CON UN SOLO ELEMENTO (COLUMNA PAIS_ID) Y SE AGREGA A LA TABLA 
            //EN SU ATRIBUTO PRIMARYKEY
            //NOTAR QUE LA TABLA PUEDE ACCEDERSE TANTO CON SU NOMBRE (PAIS) COMO POR SU INDICE EN LA COLECCION TABLES (1)
            Ds.Tables["Pais"].PrimaryKey = new DataColumn[] { Ds.Tables[1].Columns["Codigo_Pais"] };

            //POR ULTIMO CREAMOS LA RELACION ENTRE LA FOREIGNKEY "PERSONA_PAIS_ID" DE LA TABLA PERSONA
            //Y LA CLAVE PRIMARIA "PAIS_ID" DE LA TABLA PAIS
            Ds.Relations.Add("Relacion_Persona_Pais", Ds.Tables[1].Columns["Codigo_Pais"], Ds.Tables[0].Columns["Persona_Pais_Id"]);

            return Ds;
        }

 
          public void CargarDs(DataSet DSet)
            {
	            //LLENAMOS LA TABLA PAIS
	            var _with1 = DSet.Tables["Pais"].Rows;
	            _with1.Add(1, "Argentina");
	            _with1.Add(2, "Chile");
	            _with1.Add(3, "Brasil");
	            _with1.Add(4, "Peru");
	            _with1.Add(5, "Paraguay");
	            _with1.Add(6, "Bolivia");
	            _with1.Add(7, "Venezuela");
	            _with1.Add(8, "Ecuador");
                _with1.Add(9, "Uruguay");
                _with1.Add(10, "Colombia");

            //LLENAMOS LA TABLA PERSONA
            LlenarTabla(DSet, "Persona");
          
        }
        
    
        public static void LlenarTabla(DataSet DSet, string NombreTabla)
        {
            // Creo una Fila
            int i;
            for (i = 0; (i <= 9); i++)
            {
                DataRow drow = DSet.Tables[NombreTabla].NewRow();
                drow["Nombre"] = FNombre();
                drow["Apellido"] = FApellido();
                drow["FechaNac"] = Convert.ToDateTime(FechaAleatoria());
                drow["Persona_Pais_Id"] = FPais();
              DSet.Tables[NombreTabla].Rows.Add(drow);
                drow = null;
            }

            

        }

        static string FNombre()
        {
            string N = null;
            Random rdn = new Random();
            int a = rdn.Next(1, 5);

            switch (a)
            {
                case 1:
                    N = "Juan";
                    break;
                case 2:
                    N = "Pedro";
                    break;
                case 3:
                    N = "Lorena";
                    break;
                case 4:
                    N = "Analia";
                    break;
                case 5:
                    N = "Pepe";
                    break;
            }
            return N;
        }
 
        static string FApellido()
        {
            string N = null;
            Random rdn = new Random();
            int a = rdn.Next(1, 5);

            switch (a)
            {
                case 1:
                    N = "Perez";
                    break;
                case 2:
                    N = "Lopez";
                    break;
                case 3:
                    N = "Garcia";
                    break;
                case 4:
                    N = "Fernandez";
                    break;
                case 5:
                    N = "Gomez";
                    break;
            }
            return N;
        }

        static string FechaAleatoria()
        {
            Random rdnD = new Random();
            Random rdnM = new Random();
            Random rdnA = new Random();
            string Fecha = null;
            return Fecha = Fecha = rdnD.Next(1, 31) + "/" + rdnM.Next(1, 12) + "/" + rdnA.Next(1960, 2020);
        }

        static int FPais()
        {
            Random rdnP = new Random();
            return rdnP.Next(1,10 );
        }


        // *******************************************************************************
        //     ABM SIMPLE
        // *******************************************************************************
        public void DescartarCambios(DataSet Dset)
        {
            // SE DESCARTAN TODOS LOS CAMBIOS DEL DATASET
            Dset.RejectChanges();
        }

      public void GrabarCambios(string NombreTabla, DataSet Dset)
        {
            string Str = @"Data Source=.\SQLEXPRESS02;Initial Catalog=Ejemplos_LUG;Integrated Security=True";
            Da = new SqlDataAdapter(("SELECT * FROM " + NombreTabla), Str);
            // SE SETEAN LOS METODOS PARA GUARDAR DATOS EN BASE DE DATOS
            SqlCommandBuilder Cb = new SqlCommandBuilder(Da);
            Da.UpdateCommand = Cb.GetUpdateCommand();
            Da.DeleteCommand = Cb.GetDeleteCommand();
            Da.InsertCommand = Cb.GetInsertCommand();
            Da.ContinueUpdateOnError = true;
            Da.Fill(Dset);
            // SE INTENTAN PERSISTIR LOS CAMBIOS EN LA BASE DE DATOS
            Da.Update(Dset.Tables[0]);
        }
    }
}
