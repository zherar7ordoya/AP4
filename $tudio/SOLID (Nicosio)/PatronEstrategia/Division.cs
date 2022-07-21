using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronEstrategia
{
    class Division : IOperacion
    {
        public double Operacion(double a, double b)
        {
            return a / b;
        }
    }
}
