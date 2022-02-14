using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DAO
{
    internal class Conexion
    {
        // El patrón Data Access object (DAO), consiste en utilizar un objeto de acceso
        // a datos para abstraer y encapsular todos los accesos a la fuente de datos.
        // El DAO maneja la conexión con la fuente de datos para obtener y almacenar
        // datos.

        /// <summary>
        /// Esta clase solo tendrá la cadena de conexión a SQL Server y será
        /// una súper-clase. Es decir, será heredada por todas las clases DAO.
        /// </summary>

        protected SqlConnection Conn =
            new(@"Data Source=(LocalDB)\MSSQLLocalDB;
                Initial Catalog=RJCodeAdvance; 
                Integrated Security=True;");
    }
}
