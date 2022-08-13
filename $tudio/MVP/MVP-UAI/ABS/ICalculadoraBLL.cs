using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS
{
    public interface ICalculadoraBLL
    {
        void Sumar(object sender, EventArgs e);
        void Reiniciar(object sender, EventArgs e);
        decimal ObtenerNumero(string texto);
    }
}
