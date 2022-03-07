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
            goto Señalador;

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

            //*-----------------------------------------*

            WriteLine("\nNODOS");

            var escuela =
                new XElement("Escuela",
                    new XElement("Ciencias",
                        new XElement("Materia", "Matemáticas"),
                        new XElement("Materia", "Física")
                    ),
                    new XElement("Artes",
                        new XElement("Materia", "Historia del Arte"),
                        new XElement("Práctica", "Pintura")
                    )
                );

            WriteLine("\nEstructura:\n" + escuela);

            WriteLine("\nNodos:");
            foreach (XNode nodo in escuela.Nodes()) WriteLine(nodo.ToString());

            WriteLine("\nElementos:");
            foreach (XElement elemento in escuela.Elements()) WriteLine(elemento.Name + "=" + elemento.Value);

            WriteLine("\nFirstNode regresa el primer nodo:\n" + escuela.FirstNode);

            WriteLine("\nPadre del primer nodo:\n" + escuela.FirstNode.Parent.Name);

            WriteLine("\nEl último nodo:\n" + escuela.LastNode);

            /*-------------------*/

            WriteLine("\nQueries sobre XML\n");

            IEnumerable<string> materias = from curso in escuela.Elements()
                                           where curso.Elements().Any(materia => materia.Value == "Física")
                                           select curso.Value;

            foreach (string materia in materias) WriteLine(materia);

            IEnumerable<XName> nombres = from curso in escuela.Elements()
                                         where curso.Elements().Any(materia => materia.Value == "Física")
                                         select curso.Name;
            foreach (XName nombre in nombres) WriteLine(nombre.ToString());

            WriteLine("\nMas consultas sobre XML\n");

            materias = from curso in escuela.Elements()
                       from asignatura in curso.Elements()
                       where asignatura.Name == "Materia"
                       select asignatura.Value;
            foreach (string materia in materias) WriteLine(materia);

            int conteo = escuela.Elements("Ciencias").Count();
            WriteLine("Ciencias: " + conteo);

            WriteLine("\nNEXTNODE\n");

            XNode inicio = escuela.FirstNode;
            WriteLine(inicio);
            inicio = inicio.NextNode;
            WriteLine(inicio);

            WriteLine("\nAGREGAR ELEMENTO\n");

            escuela.SetElementValue("Deportes", "No hay...");
            WriteLine(escuela);

            WriteLine("*********************************************");

            escuela.SetElementValue("Deportes", "Sin presupuesto");
            WriteLine(escuela);

            WriteLine("*********************************************");

            WriteLine("\nAGREGAR ELEMENTO CON NODO COMO REFERENCIA\n");
            escuela.FirstNode.AddAfterSelf(new XElement("Asignaturas"));
            WriteLine(escuela);

            WriteLine("*********************************************");

            escuela.FirstNode.AddBeforeSelf(new XElement("EscuelaLibre"));
            WriteLine(escuela);

            WriteLine("*********************************************");

            //*/////////////////////////////////////////////////////////////*//

            Señalador:

            WriteLine("\nXML Notepad (Rocks!)\n");

            XDocument alumnado = XDocument.Load("Alumnos.xml");
            WriteLine(alumnado);

            WriteLine("\nEliminar maestros");
            alumnado.Descendants("Maestros").Remove();
            WriteLine(alumnado);

            WriteLine("\nEliminar calificaciones");
            alumnado.Descendants("Calificación").Remove();
            WriteLine(alumnado);

            //*/////////////////////////////////////////////////////////////*//
            ReadKey();
        }
    }
}
