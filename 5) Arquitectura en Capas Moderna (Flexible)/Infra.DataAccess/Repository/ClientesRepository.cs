using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Domain.Models.Abstractions;
using Domain.Models.Entities;

namespace Infra.DataAccess.Repository
{
    public class ClientesRepository : Connection, IClientesRepository
    {
        public int add(ClientesEntity cliente)
        {
            throw new NotImplementedException();
        }

        public int edit(ClientesEntity cliente)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClientesEntity> GetClients(string filtro)
        {
            /**
             * El patrón Data Access object (DAO), consiste en utilizar un objetoSqlDataReader
             * de acceso a datos para abstraer y encapsular todos los accesos a la
             * fuente de datos. El DAO maneja la conexión con la fuente de datos
             * para obtener y almacenar datos.
             * Esta clase solo debería contener métodos CRUD.
             */
            SqlDataReader LecturaRegistros;
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexion;
            Comando.CommandText = "VerRegistros";   //Stored Procedure
            Comando.CommandType = CommandType.StoredProcedure; //¿Ves?
            Comando.Parameters.AddWithValue("@Condicion", filtro);

            Conexion.Open();
            LecturaRegistros = Comando.ExecuteReader();

            /**
             * DTO puede hacerse a través de tres formas:
             *      -Lista genérica
             *      -Diccionario
             *      -Serialización (XML, JSON, Nativa)
             *  Aquí usaremos una lista genérica.
             */

            List<ClientesEntity> ListadoClientes = new List<ClientesEntity>();

            while (LecturaRegistros.Read())
            {
                ListadoClientes.Add(new ClientesEntity
                {
                    ID = LecturaRegistros.GetInt32(0),
                    Nombre = LecturaRegistros.GetString(1),
                    Apellido = LecturaRegistros.GetString(2),
                    Direccion = LecturaRegistros.GetString(3),
                    Ciudad = LecturaRegistros.GetString(4),
                    Email = LecturaRegistros.GetString(5),
                    Telefono = LecturaRegistros.GetString(6),
                    Ocupacion = LecturaRegistros.GetString(7),
                });
            }
            LecturaRegistros.Close();
            Conexion.Close();
            return ListadoClientes;
        }

        public int remove(ClientesEntity cliente)
        {
            throw new NotImplementedException();
        }
    }
}
