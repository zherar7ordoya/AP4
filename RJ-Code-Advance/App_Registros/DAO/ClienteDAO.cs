
// El patrón Data Access object (DAO), consiste en utilizar un objeto de acceso
// a datos para abstraer y encapsular todos los accesos a la fuente de datos.
// El DAO maneja la conexión con la fuente de datos para obtener y almacenar
// datos.

using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using App_Registros.DTO;

namespace App_Registros.DAO
{
    internal class ClienteDAO : ConexionBD
    {
        // Esta clase solo debería contener métodos CRUD.

        SqlDataReader LeerFilas;
        readonly SqlCommand Comando = new SqlCommand();

        public List<ClientesDTO> VerRegistros(string Condicion)
        {
            Comando.Connection  = Conexion;
            Comando.CommandText = "VerRegistros";
            Comando.CommandType = CommandType.StoredProcedure;

            Comando.Parameters.AddWithValue("@Condicion", Condicion);
            Conexion.Open();
            LeerFilas = Comando.ExecuteReader();
            List<ClientesDTO> ListaGenerica = new List<ClientesDTO>();

            while (LeerFilas.Read())
            {
                ListaGenerica.Add(new ClientesDTO
                {
                    ID        = LeerFilas.GetInt32(0),
                    Nombre    = LeerFilas.GetString(1),
                    Apellido  = LeerFilas.GetString(2),
                    Direccion = LeerFilas.GetString(3),
                    Ciudad    = LeerFilas.GetString(4),
                    Email     = LeerFilas.GetString(5),
                    Telefono  = LeerFilas.GetString(6),
                    Ocupacion = LeerFilas.GetString(7),

                });
            }
            LeerFilas.Close();
            Conexion.Close();
            return ListaGenerica;
        }
    }
}
