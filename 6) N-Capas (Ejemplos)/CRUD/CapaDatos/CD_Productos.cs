using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Productos
    {
        private CD_Conexion conexion = new CD_Conexion();
        private SqlDataReader lector;
        private DataTable tabla = new DataTable();
        private SqlCommand comando = new SqlCommand();

        public DataTable CD_MuestraProductos()
        {
            /**
             * Con Transact-SQL
             */
            //comando.Connection = conexion.AbreConexion();
            //comando.CommandText = "SELECT * FROM Productos";
            //lector = comando.ExecuteReader();
            //tabla.Load(lector);
            //conexion.CierraConexion();
            //return tabla;

            /**
             * Con Stored Procedure
             */
            comando.Connection = conexion.AbreConexion();
            comando.CommandText = "MostrarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            lector = comando.ExecuteReader();
            tabla.Load(lector);
            conexion.CierraConexion();
            return tabla;
        }
    }
}
