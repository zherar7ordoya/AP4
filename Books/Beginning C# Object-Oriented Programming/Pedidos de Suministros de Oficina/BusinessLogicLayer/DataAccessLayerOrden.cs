using System;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    /// <summary>
    /// Cuando un cliente está listo para enviar un pedido, llamará al método
    /// RealizarPedido de la clase Orden (capa de lógica empresarial). El
    /// cliente pasará la identificación del empleado al método y recibirá un
    /// número de pedido como valor de retorno. El método RealizarPedido de la
    /// clase Orden pasará la información del pedido en forma de cadena XML a
    /// la clase DataAccessLayerOrden para su procesamiento. La clase 
    /// DataAccessLayerOrden contiene el método RealizarPedido que recibe una
    /// cadena de pedido XML de la clase Orden y la pasa a un procedimiento
    /// almacenado en la base de datos de SQL Server. El procedimiento
    /// almacenado actualiza la base de datos y devuelve el número de pedido.
    /// Este número de pedido luego se devuelve a la clase Orden, que a su vez
    /// se lo devuelve al cliente.
    /// </summary>
    class DataAccessLayerOrden
    {
        public int RealizarPedido(string orden)
        {
            string cadena = DataAccessLayerUtilidad.ObtenerConexionSQL("ConexionPSO");
            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                using (SqlCommand comando = conexion.CreateCommand())
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.CommandText = "RealizarPedido";

                    SqlParameter parametro_enviado = new SqlParameter
                    {
                        ParameterName = "@orden",
                        Value = orden,
                        DbType = DbType.String,
                        Direction = ParameterDirection.Input
                    };
                    comando.Parameters.Add(parametro_enviado);

                    SqlParameter parametro_regresado = new SqlParameter
                    {
                        ParameterName = "@Id_Orden",
                        Direction = ParameterDirection.ReturnValue
                    };

                    comando.Parameters.Add(parametro_regresado);
                    int clave;
                    conexion.Open();
                    comando.ExecuteNonQuery();
                    conexion.Close();
                    clave = (int)comando.Parameters["@Id_Orden"].Value;
                    return clave;
                }
            }
        }
    }
}
