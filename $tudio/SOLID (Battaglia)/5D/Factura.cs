using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5D
{
    class Factura : DocumentoContable
    {
        public Factura(int numero, DateTime fecha, double importe) : base(numero, fecha, importe)
        {
            sigla = "FC";
        }

        public override double Total()
        {
            return Importe * 1.21;
        }
    }
}
