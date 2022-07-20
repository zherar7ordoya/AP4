using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1__S_
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("Gerardo", "Facturador", 44, 44000);

            Console.WriteLine(empleado);
            Console.WriteLine(Hacienda.CalcularImpuesto(empleado));
            Hacienda.PagarImpuesto(empleado);

            Console.ReadKey();
        }
    }
}
