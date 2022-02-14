using Design_Patterns.Models.DTO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Design_Patterns.Models.DAO
{
    internal class DAOCliente : DAOConexion
    {
        /**
         * El patrón Data Access object (DAO), consiste en utilizar un objeto
         * de acceso a datos para abstraer y encapsular todos los accesos a la
         * fuente de datos. El DAO maneja la conexión con la fuente de datos
         * para obtener y almacenar datos.
         * Esta clase solo debería contener métodos CRUD.
         */

        SqlDataReader LecturaRegistros;
        readonly SqlCommand Comando = new SqlCommand();

        public List<DTOClientes> RecuperarRegistros(string condicion)
        {
            Comando.Connection = Conexion;
            Comando.CommandText = "VerRegistros";   //Stored Procedure
            Comando.CommandType = CommandType.StoredProcedure; //¿Ves?
            Comando.Parameters.AddWithValue("@Condicion", condicion);

            Conexion.Open();
            LecturaRegistros = Comando.ExecuteReader();
            List<DTOClientes> ListadoClientes = new List<DTOClientes>();

            while (LecturaRegistros.Read())
            {
                ListadoClientes.Add(new DTOClientes
                {
                    ID          = LecturaRegistros.GetInt32(0),
                    Nombre      = LecturaRegistros.GetString(1),
                    Apellido    = LecturaRegistros.GetString(2),
                    Direccion   = LecturaRegistros.GetString(3),
                    Ciudad      = LecturaRegistros.GetString(4),
                    Email       = LecturaRegistros.GetString(5),
                    Telefono    = LecturaRegistros.GetString(6),
                    Ocupacion   = LecturaRegistros.GetString(7),
                });
            }
            LecturaRegistros.Close();
            Conexion.Close();
            return ListadoClientes;
        }
        public static void Insert() { }
        public static void Edit() { }
        public static void Delete() { }
    }
}
