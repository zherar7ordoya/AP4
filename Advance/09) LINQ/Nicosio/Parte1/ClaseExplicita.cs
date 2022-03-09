using System.Collections.Generic;
using System.Linq;

namespace Parte1
{
    public class ClaseExplicita
    {
        // Query dentro de una clase.
        private static string[] letra =
            {
                "enero",
                "febrero",
                "marzo",
                "abril",
                "mayo",
                "junio",
                "julio",
                "agosto",
                "septiembre",
                "octubre",
                "noviembre",
                "diciembre"
            };

        private static IEnumerable<string> encontrados = from x in letra
                                                         where x.Contains("a")
                                                         orderby x
                                                         select x;


        // Método que regresa el query de la clase.
        public static IEnumerable<string> ObtenerLetra() => encontrados;


        // Query dentro de un método.
        public static IEnumerable<int> ObtenerPares()
        {
            int[] numeros = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            var pares = from n in numeros
                        where n % 2 == 0
                        select n;
            return pares;
        }


        // Método que regresa el resultado de un query inmediato.
        public static int[] ObtenerImpares()
        {
            int[] numeros = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            var impares = from n in numeros
                          where n % 2 != 0
                          select n;
            return impares.ToArray();
        }
    }
}
