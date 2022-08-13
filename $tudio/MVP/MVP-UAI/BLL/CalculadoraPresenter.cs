using ABS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CalculadoraPresenter : ICalculadoraBLL
    {
        readonly ICalculadoraUIL vista;
        readonly ICalculadoraBEL modelo;

        public CalculadoraPresenter(ICalculadoraUIL vista, ICalculadoraBEL modelo)
        {
            this.vista = vista;
            this.modelo = modelo;
            this.vista.Sumar += Sumar;
            this.vista.Reiniciar += Reiniciar;
            this.vista.Show(); // Este Show es nativo del form (no tocar).
        }

        public void Sumar(object sender, EventArgs e)
        {
            modelo.CalcularTotal(new List<string> {vista.Valor1, vista.Valor2, vista.Valor3 }.ConvertAll(ObtenerNumero));
            vista.Total = Convert.ToString(modelo.Total);
            vista.Acumulado = Convert.ToString(modelo.Acumulado);
        }

        public void Reiniciar(object sender, EventArgs e)
        {
            modelo.ReiniciarTotal();
            vista.Valor1 = vista.Valor2 = vista.Valor3 = vista.Total = vista.Acumulado = string.Empty;
        }

        public decimal ObtenerNumero(string texto)
        {
            return decimal.TryParse(texto, out decimal numero) ? numero : 0;
        }
    }
}
