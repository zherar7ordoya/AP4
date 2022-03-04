using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pares = ClaseExplicita.ObtenerNumerosPares();
            var postres = ClaseExplicita.ObtenerPostres();
            var impares = ClaseExplicita.ObtenerNumerosImpares();

            WriteLine("\nPARES");
            WriteLine(string.Join(",\n", pares));
            WriteLine("\nPOSTRES");
            WriteLine(string.Join(",\n", postres));
            WriteLine("\nIMPARES");
            WriteLine(string.Join(",\n", impares));

            //*-------------------------*
            ReadKey();
        }
    }
}
