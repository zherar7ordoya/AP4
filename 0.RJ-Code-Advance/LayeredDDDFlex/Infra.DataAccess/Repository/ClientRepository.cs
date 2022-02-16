using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Domain.Model.Abstractions;
using Domain.Model.Entities;

namespace Infra.DataAccess.Repository
{
    public class ClientRepository : ConnectionSQL, IClientRepository
    {
        public int add(Client client)
        {
            throw new NotImplementedException();
        }


        public int edit(Client client)
        {
            throw new NotImplementedException();
        }


        public IEnumerable<Client> GetClients(string filter)
        {
            SqlDataReader LeerFilas;
            SqlCommand Comando = new SqlCommand();

            Comando.Connection = Conexion;
            Comando.CommandText = "VerRegistros";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Condicion", filter);

            Conexion.Open();
            LeerFilas = Comando.ExecuteReader();

            List<Client> ListaGenerica = new List<Client>();

            while (LeerFilas.Read())
            {
                ListaGenerica.Add(new Client
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


        public int remove(Client client)
        {
            throw new NotImplementedException();
        }
    }
}
