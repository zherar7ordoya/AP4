using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Employees
    {
        public int IdPK { get; set; }
        public string IdNumber { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public DateTime Birthday { get; set; }
    }
}
