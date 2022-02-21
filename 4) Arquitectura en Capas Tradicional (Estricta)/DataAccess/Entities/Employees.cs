using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    internal class Employees
    {
        public int idPK { get; set; }
        public string idNumber { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public DateTime birthday { get; set; }
    }
}
