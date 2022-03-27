using System.Data.SqlClient;

namespace Capa_de_Acceso_a_Datos
{
    public abstract class Conexión
    {
        protected SqlConnection Conectar()
        {
            return new SqlConnection
            (
                "Data Source=(LocalDB)\\MSSQLLocalDB;" +
                "Initial Catalog=BikeStore;" +
                "Integrated Security=True;" +
                "Connection Timeout=60"
            );
        }
    }
}
