using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Orden : ENTIDAD
    {
        public int OrdenID { get; set; }
        public int Legajo { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
    }
}
