using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Parte3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rand.Next(0, 100);
            }

            int[] todos = (from x in numeros select x).ToArray();
            WriteLine("Todos: " + string.Join(", ", todos));

            //*/////////////////////////////////////////////////////////////*//

            IEnumerable<int> primeros = numeros.Take(5);
            WriteLine("Solo 5 primeros: " + string.Join(", ", primeros));

            IEnumerable<int> brincados = numeros.Skip(5);
            WriteLine("Brinca 5 primeros: " + string.Join(", ", brincados));

            IEnumerable<int> reversa = numeros.Reverse();
            WriteLine("Reversa: " + string.Join(", ", reversa));

            int indice = numeros.ElementAt(2);
            WriteLine("El que está en el índice 2: " + indice);

            WriteLine("¿El vector tiene un 7?: " + numeros.Contains(7));

            WriteLine("¿El vector tiene elemento alguno?: " + numeros.Any());

            WriteLine("¿El vector tiene múltiplos de 7?: " + numeros.Any(x => x % 7 == 0));

            int[] pares = (from x in numeros where x % 2 == 0 select x).ToArray();
            WriteLine("Pares: " + string.Join(", ", pares));

            int[] impares = (from x in numeros where x % 2 != 0 select x).ToArray();
            WriteLine("Impares: " + string.Join(", ", impares));

            int primero = (from x in numeros select x).First();
            WriteLine($"Primero: {primero}");

            int ultimo = (from x in numeros select x).Last();
            WriteLine($"Último: {ultimo}");

            int[] ascendentes = numeros.OrderBy(x => x).ToArray();
            WriteLine("Ascendentes: " + string.Join(", ", ascendentes));

            int[] descendentes = numeros.OrderByDescending(x => x).ToArray();
            WriteLine("Descendentes: " + string.Join(", ", descendentes));

            int maximo = (from x in numeros select x).Max();
            WriteLine($"Máximo: {maximo}");

            int minimo = (from x in numeros select x).Min();
            WriteLine($"Mínimo: {minimo}");

            double promedio = (from x in numeros select x).Average();
            WriteLine($"Promedio: {promedio}");

            int sumatoria = (from x in numeros select x).Sum();
            WriteLine($"Sumatoria: {sumatoria}");

            // Make an IsPrime delegate.
            Func<int, bool> IsPrime = number =>
            {
                if (number == 0) return false;
                else if (number < 0) number = -number;
                if (number == 1) return false;
                if (number == 2) return true;
                if (number % 2 == 0) return false;

                for (int i = 3; i * i <= number; i += 2)
                {
                    if (number % i == 0) return false;
                }

                return true;
            };

            // Use LINQ to find the prime numbers.
            int[] primos = (from x in numeros where IsPrime(x) select x).ToArray();
            WriteLine("Primos (LINQ): " + string.Join(", ", primos));

            // Use PLINQ to find the prime numbers.
            primos = (from x in numeros.AsParallel() where IsPrime(x) select x).ToArray();
            WriteLine("Primos (PLINQ): " + string.Join(", ", primos));

            //*/////////////////////////////////////////////////////////////*//

            ReadKey();
        }
    }
}
