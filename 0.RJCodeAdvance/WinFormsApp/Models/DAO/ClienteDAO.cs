using System.Data;
using System.Data.SqlClient;
using WinFormsApp.Models.DTO;

namespace WinFormsApp.Models.DAO
{
    internal class ClienteDAO : DBContext
    {
        SqlDataReader? LeerFilas;
        readonly SqlCommand Comando = new SqlCommand();

        public List<ClienteDTO> VerRegistros(string Condicion)
        {
            Comando.Connection = Conexion;
            Comando.CommandText = "VerRegistros";
            Comando.CommandType = CommandType.StoredProcedure;

            Comando.Parameters.AddWithValue("@Condicion", Condicion);
            Conexion.Open();
            LeerFilas = Comando.ExecuteReader();

            /**
             * DTO puede hacerse a través de tres formas:
             *  -Lista genérica*
             *  -Diccionario
             *  -Serialización (XML, JSON, Nativa)
             *  
             *  Aquí estamos usando una lista genérica.
             */

            List<ClienteDTO> ListaGenerica = new List<ClienteDTO>();

            while (LeerFilas.Read())
            {
                ListaGenerica.Add(new ClienteDTO
                {
                    ID = LeerFilas.GetInt32(0),
                    Nombre = LeerFilas.GetString(1),
                    Apellido = LeerFilas.GetString(2),
                    Direccion = LeerFilas.GetString(3),
                    Ciudad = LeerFilas.GetString(4),
                    Email = LeerFilas.GetString(5),
                    Telefono = LeerFilas.GetString(6),
                    Ocupacion = LeerFilas.GetString(7),
                });
            }
            LeerFilas.Close();
            Conexion.Close();
            return ListaGenerica;
        }
    }
}
