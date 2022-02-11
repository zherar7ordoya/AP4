using System.Data.SqlClient;

namespace Infra.DataAccess.Repository
{
    public class ConnectionSQL
    {
        protected SqlConnection Conexion = new SqlConnection("Server=(LocalDB)\\MSSQLLocalDB; DataBase=Practica_Patrones; Integrated Security=true;");
    }
}
