using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5D
{
    class FacturaLuz : Impuesto
    {
        public FacturaLuz(double importe, string codigoPago) : base(importe)
        {
            CodigoPago = codigoPago;
        }

        public string CodigoPago { get; set; }
    }
}
