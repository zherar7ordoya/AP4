using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    public class ClaseExplicita
    {
        // Query dentro de una clase.
        private static string[] postres =
            {
                "tarta de manzana",
                "manzana al horno",
                "flan de frutilla",
                "manzana acaramelada",
                "tarta de duraznos"
            };

        private static IEnumerable<string> encontrados = from x in postres
                                                        where x.Contains("manzana")
                                                        orderby x
                                                        select x;


        // Método que regresa el query de la clase.
        public static IEnumerable<string> ObtenerPostres() => encontrados;


        // Query dentro de un método.
        public static IEnumerable<int> ObtenerNumerosPares()
        {
            int[] numeros = { 1, 5, 7, 3, 6, 9, 8 };
            var pares = from n in numeros
                        where n % 2 == 0
                        select n;
            return pares;
        }


        // Método que regresa el resultado de un query inmediato.
        public static int[] ObtenerNumerosImpares()
        {
            int[] numeros = { 1, 5, 7, 3, 6, 9, 8 };
            var impares = from n in numeros
                          where n % 2 != 0
                          select n;
            return impares.ToArray();
        }
    }
}
