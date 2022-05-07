using System.Data.SqlClient;
namespace OfficeSupplyBLL
{
    class DALEmpleado
    {
        public int LogIn(string username, string password)
        {
            string connString = DALConector.GetSQLConnection("ConexionConBBDD");
            using (SqlConnection conn = new SqlConnection(connString))

            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = 
                        "SELECT ID_Empleado " +
                        "FROM Empleados " +
                        "WHERE Usuario = @username AND Contraseña = @password";
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    int userId;
                    conn.Open();
                    userId = (int)cmd.ExecuteScalar();
                    if (userId > 0)
                    {
                        return userId;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }

        }
    }
}