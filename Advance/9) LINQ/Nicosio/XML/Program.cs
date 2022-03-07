using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Xml.Linq;

namespace XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("\nEJEMPLO 1");

            XElement raiz = new XElement("raiz");
            XElement el1 = new XElement("Elemento1");
            el1.Add(new XAttribute("atributo", "valor"));
            el1.Add(new XElement("Anidado", "Contenido"));
            raiz.Add(el1);
            WriteLine(raiz);

            //*-----------------------------------------*

            WriteLine("\nEJEMPLO 2");

            XElement documento = 
                new XElement("Alumnos",
                new XElement("Ana", new XAttribute("ID", "10100"),
                new XElement("Promedio", "10")
                ),
                new XElement("Luis", new XAttribute("ID", "25350"),
                new XElement("Curso", "Programación"),
                new XElement("Promedio", "9.5")
                )
                );
            Console.WriteLine(documento);
            documento.Save("Alumnos.xml");

            //*-----------------------------------------*

            WriteLine("\nEJEMPLO 3");

            var listado = new[]
            {
                new {Nombre="José", Calificacion=8, Curso="Programación"},
                new {Nombre="Susana", Calificacion=9, Curso="UML"},
                new {Nombre="María", Calificacion=10, Curso="Orientado a Objetos"},
                new {Nombre="Luis", Calificacion=10, Curso="UML"},
            };
            XElement alumnos = new XElement("Alumnos",
                from a in listado
                select new XElement("Alumno", new XAttribute("Nombre", a.Nombre),
                new XElement("Curso", a.Curso),
                new XElement("Calificación", a.Calificacion)
                ));
            WriteLine(alumnos);
            alumnos.Save("Alumnos.xml");

            //*/////////////////////////////////////////////////////////////*//
            ReadKey();
        }
    }
}
