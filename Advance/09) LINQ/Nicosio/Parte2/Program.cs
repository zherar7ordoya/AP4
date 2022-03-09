using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Parte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> conjunto1 = new List<int> { 2, 4, 6, 8, 9 };
            List<int> conjunto2 = new List<int> { 2, 5, 6, 7, 9 };

            WriteLine("\nConjunto 1:\t" + String.Join(", ", conjunto1));
            WriteLine("Conjunto 2:\t" + String.Join(", ", conjunto2));

            var excepto = (from n1 in conjunto1 select n1).Except(from n2 in conjunto2 select n2);
            Console.Write("\nExcept es lo que hay en C1 que no hay en C2:");
            foreach (int i in excepto) Write(" "+ i);

            var comun = (from n1 in conjunto1 select n1).Intersect(from n2 in conjunto2 select n2);
            Console.Write("\n\nIntersect es lo que hay de común en C1 y C2:");
            foreach (int i in comun) Write(" " + i);

            var unicos = (from n1 in conjunto1 select n1).Union(from n2 in conjunto2 select n2);
            Console.Write("\n\nUnion es lo que hay en C1 y C2 (sin repeticiones):");
            foreach (int i in unicos) Write(" " + i);

            var concatenados = (from n1 in conjunto1 select n1).Concat(from n2 in conjunto2 select n2);
            Console.Write("\n\nConcat es lo que hay en C1 y C2 (todo, con repeticiones):");
            foreach (int i in concatenados) Write(" " + i);

            Console.Write("\n\nDistinct remueve duplicados (en este caso, los de Concat):");
            foreach (int i in concatenados.Distinct()) Write(" " + i);

            Console.Write("\n\nDistinct no altera la lista original:");
            foreach (int i in concatenados) Write(" " + i);

            //*//////////////////////////////*//
            Console.ReadKey();
        }
    }
}
