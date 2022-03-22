using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConnectionSQL
    {
        protected SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; Initial Catalog=C:\\DOCUMENTS\\AP4\\ADVANCE\\06) N - CAPAS(EJEMPLOS)\\SALESREPORT\\BIKE_STORE.MDF; Integrated Security = True");
        }
    }
}
