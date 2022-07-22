using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5D
{
    public class ReciboSueldo
    {
        public ReciboSueldo(int legajo, double total)
        {
            Total = total;
            Legajo = legajo;
        }

        public double Total { get; set; }
        public int Legajo { get; set; } 
    }
}
