using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace Codelligent
{
    /// <summary>
    /// https://youtu.be/H6AvBDcTn3g
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1RA PARTE
            // Buscar estudiantes con Class=10 y listar sus Subjects.

            WriteLine("\n1ra Parte.---------------------------------------\n");

            var filepath = @"Students.xml";
            var studentsData = XElement.Load(filepath);
            var data = studentsData
                .Descendants("Student")
                .Where(st => (int)st.Element("Class") == 10);

            foreach (var student in data)
            {
                WriteLine($"{student.Element("Name").Value}");
                var marks = student.Descendants("Subject");
                foreach (var mark in marks) WriteLine($"    {mark.Attribute("Title").Value}: {mark.Value}");
            }

            // 2DA PARTE
            // Buscar información de estudiantes con Marks de Math Subject
            // superiores a 85.

            WriteLine("\n2da Parte.---------------------------------------\n");

            data = studentsData
                .Descendants("Student")
                .Where(st =>
                {
                    var subjects = st.Element("Marks").Descendants("Subject");
                    var mathSubjects = subjects.FirstOrDefault(sub => (string)sub.Attribute("Title") == "Maths");
                    return (int)mathSubjects > 85;
                });

            foreach (var student in data)
            {
                WriteLine($"{student.Element("Name").Value}");
                var marks = student.Descendants("Subject");
                foreach (var mark in marks) WriteLine($"    {mark.Attribute("Title").Value}: {mark.Value}");
            }

            // 3RA PARTE
            // Crear un XML.

            WriteLine("\n3ra Parte.---------------------------------------\n");

            var persons =
                new XElement("Persons",
                    new XElement("Person",
                        new XElement("Name", "Raj"),
                        new XElement("Age", "32")),
                     new XElement("Person",
                        new XElement("Name", "Tom"),
                        new XElement("Age", "30"))
                     );
            File.WriteAllText(@"Persons.xml", persons.ToString());

            ReadKey();
        }
    }
}
