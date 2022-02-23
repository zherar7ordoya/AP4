using System.Data;
using System.Data.SqlClient;

namespace CD_CapaDatos
{
    public class CD_Conexion
    {
        private SqlConnection conexion = new SqlConnection(
            "data source=(LocalDB)\\MSSQLLocalDB;" +
            "initial catalog=RJCodeAdvance;" +
            "integrated security=True");

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
    }
}
