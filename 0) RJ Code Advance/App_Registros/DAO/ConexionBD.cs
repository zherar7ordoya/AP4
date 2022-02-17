
// El patrón Data Access object (DAO), consiste en utilizar un objeto de acceso
// a datos para abstraer y encapsular todos los accesos a la fuente de datos.
// El DAO maneja la conexión con la fuente de datos para obtener y almacenar
// datos.

using System.Data.SqlClient;

namespace App_Registros.DAO
{
    internal class ConexionBD
    {
        protected SqlConnection Conexion =
            new SqlConnection("Server=(LocalDB)\\MSSQLLocalDB; DataBase=Practica_Patrones; Integrated Security=true;");
    }
}
