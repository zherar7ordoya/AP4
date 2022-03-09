using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(Entidades database = new Entidades())
            {
                var lista = database.People;

                //LISTAR
                Console.WriteLine("LISTAR.----------------------------------");
                foreach(var item in lista)
                {
                    Console.WriteLine($"{ item.id } \t { item.Nombre } \t { item.Edad }");
                }

                //AGREGAR
                Console.WriteLine("AGREGAR.---------------------------------");
                People persona = new People()
                {
                    Nombre = "Iron Man",
                    Edad = 35,
                    idSexo = 1
                };
                database.People.Add(persona);
                database.SaveChanges();
                var idBorrable = persona.id;
                lista = database.People;
                foreach (var item in lista)
                {
                    Console.WriteLine($"{ item.id } \t { item.Nombre } \t { item.Edad }");
                }

                //MODIFICAR
                Console.WriteLine("MODIFICAR.-------------------------------");
                persona = database.People.Where(x => x.Nombre == "Iron Man").FirstOrDefault();
                persona.Nombre = "The Hulk";
                persona.Edad = 40;
                database.SaveChanges();
                lista = database.People;
                foreach (var item in lista)
                {
                    Console.WriteLine($"{ item.id } \t { item.Nombre } \t { item.Edad }");
                }

                //ELIMINAR
                Console.WriteLine("ELIMINAR.--------------------------------");
                persona = database.People.Find(idBorrable);
                database.People.Remove(persona);
                database.SaveChanges();
                lista = database.People;
                foreach (var item in lista)
                {
                    Console.WriteLine($"{ item.id } \t { item.Nombre } \t { item.Edad }");
                }

                //*----------------------------------------------------------=>
                Console.ReadKey();
            }
        }
    }
}
