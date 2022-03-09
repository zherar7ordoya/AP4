using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;

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

            WriteLine("\nProyección Indexada con Select");
            IEnumerable<string> resultados = postres.Select((x, i) => "Indice " + i + " para el postre " + x);
            resultados.ToList().ForEach(x => WriteLine(x));

            WriteLine("\nSelectMany");
            resultados = postres.SelectMany(x => x.Split());
            resultados.ToList().ForEach(x => WriteLine(x));

            WriteLine("\nSelect con variables de rango");
            resultados = from x1 in postres
                         from x2 in x1.Split()
                         select x2 + "\t\t*->\t" + x1;
            resultados.ToList().ForEach(x => WriteLine(x));

            resultados = from x1 in postres
                         from x2 in postres
                         select $"{x1} - {x2}";
            resultados.ToList().ForEach(x => WriteLine(x));

            //*--------------------------------*

            List<Estudiante> estudiantes = new List<Estudiante>
            {
                new Estudiante(100,"Ana"),
                new Estudiante(150,"Mario"),
                new Estudiante(180,"Susana"),
            };
            List<Curso> cursos = new List<Curso>
            {
                new Curso(100,"Programación"),
                new Curso(150,"Orientado a Objetos"),
                new Curso(150,"Programación"),
                new Curso(180,"Programación"),
                new Curso(100,"UML"),
                new Curso(100,"Orientado a Objetos"),
                new Curso(180,"UML"),
            };

            WriteLine("\nJOIN");

            var listado1 = from e in estudiantes
                           join c in cursos
                           on e.ID equals c.ID
                           select e.Nombre + " cursa " + c.Nombre;
            listado1.ToList().ForEach(x => WriteLine(x));

            WriteLine("\nGROUPJOIN");

            var listado2 = from e in estudiantes
                           join c in cursos
                           on e.ID equals c.ID
                           into temporal
                           select new { estudiante = e.Nombre, temporal };
            foreach (var lst1 in listado2)
            {
                WriteLine("\n" + lst1.estudiante);
                foreach (var lst2 in lst1.temporal)
                {
                    WriteLine(lst2.Nombre);
                }
            }

            WriteLine("\nZIP");
            string[] helados = { "chocolate", "vainilla", "fresa", "limón" };
            IEnumerable<string> r12 = postres.Zip(helados, (p, h) => p + " con " + h);
            foreach (string r in r12) WriteLine(r);

            WriteLine("\nAGRUPAMIENTO");

            string[] archivos = Directory.GetFiles("C:\\Windows");
            
            WriteLine("\nListado:\n");
            foreach (string archivo in archivos) WriteLine(archivo);
            var agrupados = archivos.GroupBy(a => Path.GetExtension(a));

            WriteLine("\nAgrupados:\n");
            foreach(IGrouping<string, string> agrupado in agrupados)
            {
                WriteLine($"Extensión {agrupado.Key}");
                foreach (string archivo in agrupado) WriteLine($"\t{ archivo }");
            }

            //*/////////////////////////////////////////////////////////////*//
            ReadKey();
        }
    }
}
