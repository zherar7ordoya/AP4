using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace RepositoryPattern
{
    public class AppConnection
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["cn"].ConnectionString;
    }
}
