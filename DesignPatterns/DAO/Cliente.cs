using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatterns.DTO;

namespace DesignPatterns.DAO
{
    internal class Cliente : Conexion
    {
        // El patrón Data Access object (DAO), consiste en utilizar un objeto de acceso
        // a datos para abstraer y encapsular todos los accesos a la fuente de datos.
        // El DAO maneja la conexión con la fuente de datos para obtener y almacenar
        // datos.

        // Esta clase solo debería contener métodos CRUD.

        SqlDataReader? LeeRegistros;
        readonly SqlCommand Comando = new();

        public List<Clientes> VerRegistros(string Condicion)
        {
            Comando.Connection = Conn;
            Comando.CommandText = "VerRegistros"; //El "VerRegistros" aquí es el procedimiento almacenado en la BBDD.
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Condicion", Condicion);

            Conn.Open();
            LeeRegistros = Comando.ExecuteReader();
            List<Clientes> Clientes = new();

            while (LeeRegistros.Read())
            {
                Clientes.Add(new Clientes
                {
                    ID = LeeRegistros.GetInt32(0),
                    Nombre = LeeRegistros.GetString(1),
                    Apellido = LeeRegistros.GetString(2),
                    Direccion = LeeRegistros.GetString(3),
                    Ciudad = LeeRegistros.GetString(4),
                    Email = LeeRegistros.GetString(5),
                    Telefono = LeeRegistros.GetString(6),
                    Ocupacion = LeeRegistros.GetString(7),
                });
            }
            LeeRegistros.Close();
            Conn.Close();
            return Clientes;
        }
        public static void Insert() { }
        public static void Edit() { }
        public static void Delete() { }
    }
}
