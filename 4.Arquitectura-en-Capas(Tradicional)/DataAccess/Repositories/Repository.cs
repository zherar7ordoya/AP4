using System.Configuration;
using System.Data.SqlClient;

namespace DataAccess.Repositories
{
    public abstract class Repository
    {
        private readonly string Conexion;

        public Repository()
        {
            Conexion = ConfigurationManager.ConnectionStrings["FRM.Properties.Settings.Conexion"].ToString();
        }

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(Conexion);
        }
    }
}
