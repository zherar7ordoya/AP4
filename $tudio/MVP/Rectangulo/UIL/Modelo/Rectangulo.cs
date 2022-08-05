using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIL.Modelo
{
    public class Rectangulo
    {
        public double Longitud { get;set; }
        public double Amplitud { get; set; }

        public double CalcularArea()
        {
            return Longitud * Amplitud;
        }
    }
}
