using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using ConsultasMVC.Models.DTO;

namespace ConsultasMVC.Models.DAO
{
    internal class ClienteDAO : DBContext
    {
        SqlDataReader LeerFilas;
        readonly SqlCommand Comando = new SqlCommand();

        public List<Cliente> VerRegistros(string Condicion)
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

            List<Cliente> ListaGenerica = new List<Cliente>();

            while (LeerFilas.Read())
            {
                ListaGenerica.Add(new Cliente
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
