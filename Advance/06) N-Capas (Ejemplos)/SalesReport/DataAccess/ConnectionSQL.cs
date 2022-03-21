using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConnectionSQL
    {
        protected SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB; DataBase=Bike_Store; Integrated Security=True;");
        }
    }
}
