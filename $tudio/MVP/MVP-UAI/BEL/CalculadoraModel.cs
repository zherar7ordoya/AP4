using ABS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class CalculadoraModel : ICalculadoraBEL
    {
        public decimal Total { get; private set; }
        public decimal Acumulado { get; private set; }

        public void CalcularTotal(List<decimal> numeros)
        {
            Total = numeros.Sum();
            Acumulado += Total;
        }

        public void ReiniciarTotal()
        {
            Total = 0;
            Acumulado = 0;
        }
    }
}
