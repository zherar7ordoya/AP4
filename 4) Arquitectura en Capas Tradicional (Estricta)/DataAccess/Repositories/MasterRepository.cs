using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    /// <summary>
    /// 
    /// Esta clase se encargará de ejecutar los comandos Transact-SQL que se
    /// usarán en todos los repositorios.
    /// 
    /// NOTA:
    /// Al invocar a using en los métodos, invocamos a IDisposable.
    /// 
    /// </summary>
    public abstract class MasterRepository : Repository
    {


        protected List<SqlParameter> parametros;

        /// <summary>
        /// 
        /// Este método se encargará de ejecutar comandos de no-consulta, es
        /// decir, comando para insertar, editar y eliminar datos.
        /// No se recomienda el uso de procedimientos almacenados que contengan
        /// lógica de negocio ya que se sacrifica el mantenimiento a cambio del
        /// rendimiento. De ahí que el CommandType sea Text.
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        protected int ExecuteNonQuery(string sql)
        {
            using (var conexion = AbrirConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = sql;
                    comando.CommandType = CommandType.Text;

                    foreach (SqlParameter item in parametros)
                    {
                        comando.Parameters.Add(item);
                    }

                    int resultado = comando.ExecuteNonQuery();
                    parametros.Clear();
                    return resultado;
                }
            }
        }

        /// <summary>
        /// 
        /// Este método se encarga de ejecutar comandos de consulta, es decir,
        /// para leer filas de tablas y mostrar los datos de una tabla.
        /// 
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        protected DataTable ExecuteReader(string sql)
        {
            using (var conexion = AbrirConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = sql;
                    comando.CommandType = CommandType.Text;

                    SqlDataReader lectura = comando.ExecuteReader();

                    using (var tabla = new DataTable())
                    {
                        tabla.Load(lectura);
                        lectura.Dispose();
                        return tabla;
                    }
                }
            }
        }


    }
}
