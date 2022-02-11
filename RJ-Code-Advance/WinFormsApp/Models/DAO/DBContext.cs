using System.Data.SqlClient;

namespace WinFormsApp.Models.DAO
{
    public class DBContext
    {
        protected SqlConnection Conexion = new SqlConnection("Server=(LocalDB)\\MSSQLLocalDB; DataBase=Practica_Patrones; Integrated Security=true;");
    }
}
