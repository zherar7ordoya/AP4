using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5D
{
    class NotaCredito : DocumentoContable
    {
        public NotaCredito(int numero, DateTime fecha, double importe) : base(numero,fecha,importe)
        {
            sigla = "NC";
        }

        public override double Total()
        {
            return Importe * 1.21 * -1;
        }
    }
}
