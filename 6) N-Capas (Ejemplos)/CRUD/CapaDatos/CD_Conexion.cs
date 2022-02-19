using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    internal class CD_Conexion
    {
        private SqlConnection ConexionSQL =
            new SqlConnection($"Data Source=(LocalDB)\\MSSQLLocalDB;" +
                              $"Initial Catalog=RJCodeAdvance;" +
                              $"Integrated Security=True");

        public SqlConnection AbreConexion()
        {
            if(ConexionSQL.State == ConnectionState.Closed)
            {
                ConexionSQL.Open();
            }
            return ConexionSQL;
        }

        public SqlConnection CierraConexion()
        {
            if (ConexionSQL.State == ConnectionState.Open)
            {
                ConexionSQL.Close();
            }
            return ConexionSQL;
        }
    }
}
