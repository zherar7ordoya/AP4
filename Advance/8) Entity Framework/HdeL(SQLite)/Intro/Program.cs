using System;
using System.Linq;

namespace Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //using(Entidades database = new Entidades())
            //{
            //    var lista = database.Gente;

            //    //LISTAR
            //    Console.WriteLine("LISTAR.----------------------------------");
            //    foreach(var item in lista)
            //    {
            //        Console.WriteLine($"{ item.id } \t { item.Nombre } \t { item.Edad }");
            //    }

            //    //AGREGAR
            //    Console.WriteLine("AGREGAR.---------------------------------");
            //    Gente persona = new Gente()
            //    {
            //        Nombre = "Iron Man",
            //        Edad = 35,
            //        idSexo = 1
            //    };
            //    database.Gente.Add(persona);
            //    database.SaveChanges();
            //    var idBorrable = persona.id;
            //    lista = database.Gente;
            //    foreach (var item in lista)
            //    {
            //        Console.WriteLine($"{ item.id } \t { item.Nombre } \t { item.Edad }");
            //    }

            //    //MODIFICAR
            //    Console.WriteLine("MODIFICAR.-------------------------------");
            //    persona = database.Gente.Where(x => x.Nombre == "Iron Man").FirstOrDefault();
            //    persona.Nombre = "The Hulk";
            //    persona.Edad = 40;
            //    database.SaveChanges();
            //    lista = database.Gente;
            //    foreach (var item in lista)
            //    {
            //        Console.WriteLine($"{ item.id } \t { item.Nombre } \t { item.Edad }");
            //    }

            //    //ELIMINAR
            //    Console.WriteLine("ELIMINAR.--------------------------------");
            //    persona = database.Gente.Find(idBorrable);
            //    database.Gente.Remove(persona);
            //    database.SaveChanges();
            //    lista = database.Gente;
            //    foreach (var item in lista)
            //    {
            //        Console.WriteLine($"{ item.id } \t { item.Nombre } \t { item.Edad }");
            //    }

            //    //*----------------------------------------------------------=>
            //    Console.ReadKey();
            //}
        }
    }
}
