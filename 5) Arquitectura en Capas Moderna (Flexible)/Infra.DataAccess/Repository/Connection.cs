using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.DataAccess.Repository
{
    public class Connection
    {
        protected SqlConnection Conexion =
            new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
                                Initial Catalog=RJCodeAdvance; 
                                Integrated Security=True;");
    }
}
