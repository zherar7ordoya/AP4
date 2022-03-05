using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace Parte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            goto Continuar;

            ArrayList lista = new ArrayList();
            lista.AddRange(new object[] { "hola", 5, 6.7, false, 4, 2, "saludos", 3.1, 3 });

            var enteros = lista.OfType<int>();

            foreach (int x in enteros)
            { WriteLine(x); }

            //*---------------------------------*

            // ArrayList no implementa IEnumerable
            List<Estudiante> estudiantes = new List<Estudiante>
            {
                new Estudiante("Ana", "A100", "Mercadotecnia", 10.0),
                new Estudiante("Luis", "S250", "Orientado a Objetos", 9.0),
                new Estudiante("Juan", "S875", "Programación Básica", 5.0),
                new Estudiante("Susana", "A432", "Mercadotecnia", 8.7),
                new Estudiante("Pablo", "A156", "Mercadotecnia", 4.3),
                new Estudiante("Alberto", "S456", "Orientado a Objetos", 8.3)
            };
            int cantidad = (from e in estudiantes
                            where e.Promedio > 5
                            select e).Count();
            WriteLine($"Aprobados: {cantidad}");
            var aprobados = from e in estudiantes
                            where e.Promedio > 5
                            orderby e.Promedio descending
                            select e;
            foreach (Estudiante estudiante in aprobados.Reverse())
            {
                WriteLine(estudiante);
            }

        //*-------------------------*
        Continuar:

            //int[] numeros = { 3, 1, 4, 2, 10, 9, 8, 7, 6, 5 };

            // Create the numbers.
            Random rand = new Random();
            int[] numeros = new int[15];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = rand.Next(0, 100);
            }

            int[] todos = (from x in numeros select x).ToArray();
            WriteLine("Todos: " + string.Join(", ", todos));

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
