using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConnectionSQL
    {
        protected SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB; Initial Catalog=BikeStore; Integrated Security=True; Connection Timeout=60");
        }
    }
}
