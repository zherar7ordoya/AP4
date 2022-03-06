using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] postres =
                {
                "pie de manzana",
                "pastel de chocolate",
                "manzana encaramelada",
                "fresas con crema",
                "tarta de durazno",
                "tarta de manzana",
                "pie de manzanas y pera"
            };
            int[] numeros = { 1, 5, 7, 3, 5, 9, 8, 11, 2, 4 };

            WriteLine("\nTakeWhile");
            WriteLine("Todos:\t" + string.Join(", ", numeros));
            WriteLine("\t" + string.Join(", ", numeros.TakeWhile(x => x < 8)));

            WriteLine("\nSkipWhile");
            WriteLine("Todos:\t" + string.Join(", ", numeros));
            WriteLine("\t" + string.Join(", ", numeros.SkipWhile(x => x < 8)));

            //*/////////////////////////////////////////////////////////////*//
            ReadKey();
        }
    }
}
