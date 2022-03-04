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

            int[] numeros = { 1, 2, 3, 4 };
            int maximo = (from n in numeros select n).Max();
            WriteLine($"Máximo: {maximo}");

            int minimo = (from n in numeros select n).Min();
            WriteLine($"Mínimo: {minimo}");

            double promedio = (from n in numeros select n).Average();
            WriteLine($"Promedio: {promedio}");

            int sumatoria = (from n in numeros select n).Sum();
            WriteLine($"Sumatoria: {sumatoria}");

            ReadKey();
        }
    }
}
