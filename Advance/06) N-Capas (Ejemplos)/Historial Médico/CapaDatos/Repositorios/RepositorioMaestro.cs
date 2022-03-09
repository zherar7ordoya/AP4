using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos.Repositorios
{
    public abstract class RepositorioMaestro : Repositorio
    {
        protected List<SqlParameter> parametros;
        protected int ExecuteNonQuery(string transactSQL)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = transactSQL;
                    comando.CommandType = CommandType.Text;

                    foreach(SqlParameter item in parametros)
                    {
                        comando.Parameters.Add(item);
                    }

                    int resultado = comando.ExecuteNonQuery();
                    parametros.Clear();
                    return resultado;
                }
            }
        }

        protected DataTable ExecuteReader(string transactSQL)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = transactSQL;
                    comando.CommandType = CommandType.Text;
                    SqlDataReader reader = comando.ExecuteReader();

                    using (var tabla = new DataTable())
                    {
                        tabla.Load(reader);
                        reader.Dispose();
                        return tabla;
                    }
                }
            }
        }

        protected DataTable ExecuteReaderParam(string transactSQL)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = transactSQL;
                    comando.CommandType = CommandType.Text;

                    foreach(SqlParameter item in parametros)
                    {
                        comando.Parameters.Add(item);
                    }

                    SqlDataReader reader = comando.ExecuteReader();

                    using (var tabla = new DataTable())
                    {
                        tabla.Load(reader);
                        reader.Dispose();
                        return tabla;
                    }
                }
            }
        }
    }
}
