using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    /// <summary>
    /// Contiene un método de inicio de sesión (Login) que comprueba el nombre
    /// de usuario y la contraseña proporcionados a los valores de la base de
    /// datos. Utiliza un objeto SQLCommand para ejecutar una declaración SQL
    /// contra la base de datos. Si se encuentra una coincidencia, devuelve el
    /// ID de usuario del empleado. Si no se encuentra ninguna coincidencia,
    /// devuelve -1. Dado que la instrucción SQL devuelve un único valor, puede
    /// utilizar el método ExecuteScalar del objeto SQLCommand.
    /// </summary>
    class DataAccessLayerEmpleado
    {
        public int LogIn(string usuario, string contraseña)
        {
            string cadena = DataAccessLayerUtilidad.ObtenerConexionSQL("ConexionPSO");
            using (SqlConnection conexion = new SqlConnection(cadena))

            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText =
                        "SELECT EmployeeID" +
                        "FROM Employee" +
                        "WHERE UserName = @UserName AND Password = @Password";
                    comando.Parameters.AddWithValue("@UserName", usuario);
                    comando.Parameters.AddWithValue("@Password", contraseña);
                    int userId;
                    conexion.Open();
                    userId = (int)comando.ExecuteScalar();
                    if (userId > 0) return userId;
                    else return -1;
                }
            }
        }
    }
}
