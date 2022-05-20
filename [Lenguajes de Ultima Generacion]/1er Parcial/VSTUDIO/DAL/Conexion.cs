using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using static System.Console;

namespace DAL
{
    public class Conexion
    {
        private readonly SqlConnection conexion = 
            new SqlConnection(ConfigurationManager
            .ConnectionStrings["CadenaConexion"].ToString());

        public DataSet LeerDatos(string consulta)
        {
            DataSet datos = new DataSet();

            try
            {
                SqlDataAdapter adaptador = 
                    new SqlDataAdapter(
                        consulta,
                        conexion);
                adaptador.Fill(datos);
            }
            catch (SqlException ex)
            {
                WriteLine("Inner Exception: " + ex.Message);
                ReadKey();
            }
            catch (Exception ex)
            {
                WriteLine("Inner Exception: " + ex.Message);
                ReadKey();
            }
            finally
            {
                conexion.Close();
            }
            return datos;
        }


        // ¿falta RETURN FALSE?
        public bool Escribir(string Consulta_SQL)
        {
            conexion.Open();

            SqlCommand comando = new SqlCommand
            {
                CommandType = CommandType.Text,
                CommandText = Consulta_SQL,
                Connection = conexion
            };

            try
            {
                int respuesta = comando.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                WriteLine("Inner Exception: " + ex.Message);
                ReadKey();
            }
            catch (Exception ex)
            {
                WriteLine("Inner Exception: " + ex.Message);
                ReadKey();
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// ???
        /// </summary>
        /// <param name="Consulta_SQL"></param>
        /// <returns></returns>
        public bool LeerAsociacion(string Consulta_SQL)
        {
            conexion.Open();
            SqlCommand command = new SqlCommand(Consulta_SQL, conexion);
            command.CommandType = CommandType.Text;
            try
            {
                int Respuesta = Convert.ToInt32(command.ExecuteScalar());
                if (Respuesta > 0)
                { return true; }
                else
                { return false; }
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
            finally
            {
                conexion.Close();
            }
        }
    }
}
