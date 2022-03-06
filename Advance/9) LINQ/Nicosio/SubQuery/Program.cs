using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubQuery
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
            IEnumerable<string> resultados = postres.OrderBy(x => x.Split().Last());
            resultados.ToList().ForEach(x => WriteLine(x));

            int[] numeros = { 19, 14, 56, 32, 11, 8, 45, 7, 18, 2, 17, 23 };
            WriteLine(string.Join(", ", numeros));

            IEnumerable<int> nums = numeros.Where(x => x < numeros.First());
            WriteLine(string.Join(", ", nums));

            IEnumerable<int> numx = numeros.Where(x => x <= (numeros.Where(y => y % 2 == 0)).First());
            WriteLine(string.Join(", ", numx));

            //*----------------------*

            WriteLine("\nQUERY PROGRESIVO");

            bool mayusculas = false;

            var manzanas = postres.Where(x => x.Contains("manzana"));
            var ordenadas = manzanas.OrderBy(x => x);
            if (mayusculas) resultados = ordenadas.Select(x => x.ToUpper());
            else resultados = ordenadas;
            resultados.ToList().ForEach(x => WriteLine(x));

            WriteLine("\nINTO");

            IEnumerable<string> encontrados = from x in postres
                                              where x.Contains("manzana")
                                              orderby x
                                              select x
                                              into tartas
                                              where tartas.Contains("pie")
                                              select tartas;
            encontrados.ToList().ForEach(x => WriteLine(x));

            WriteLine("\nWRAPPIING");

            encontrados = from p2 in
                              (
                              from p1 in postres
                              where p1.Contains("manzana")
                              orderby p1
                              select p1
                              )
                          where p2.Contains("pie")
                          select p2;
            encontrados.ToList().ForEach(x => WriteLine(x));

            WriteLine("\nLET");

            encontrados = from x in postres
                          let manzanitas =
                              (
                              from p in postres
                              where p.Contains("manzana")
                              orderby p
                              select p
                              )
                          where x.Contains("pie")
                          select x;
            encontrados.ToList().ForEach(x => WriteLine(x));

            //*/////////////////////////////////////////////////////////////*//
            ReadKey();
        }
    }
}
