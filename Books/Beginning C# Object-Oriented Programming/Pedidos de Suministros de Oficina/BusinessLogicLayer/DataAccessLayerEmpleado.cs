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
        public int Login(string usuario, string contraseña)
        {
            string cadena = DataAccessLayerUtilidad.ObtenerConexionSQL("ConexionPSO");
            using (SqlConnection conexion = new SqlConnection(cadena))

            {
                using (SqlCommand comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText =
                        "SELECT Id_Empleado" +
                        "FROM Empleados" +
                        "WHERE Usuario = @usuario AND Contraseña = @contraseña";
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@contraseña", contraseña);
                    int idUsuario;
                    conexion.Open();
                    idUsuario = (int)comando.ExecuteScalar();
                    if (idUsuario > 0) return idUsuario;
                    else return -1;
                }
            }
        }
    }
}
