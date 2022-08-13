using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS
{
    public interface ICalculadoraBEL
    {
        decimal Total { get; }
        decimal Acumulado { get; }
        void CalcularTotal(List<decimal> numeros);
        void ReiniciarTotal();
    }
}
