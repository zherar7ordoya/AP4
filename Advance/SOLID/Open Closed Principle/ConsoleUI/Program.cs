using Filtro;
using OCPLibrary;
using System.Collections.Generic;
using static System.Console;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<PersonModel> applicants = new List<PersonModel>
            //{
            //    new PersonModel {FirstName = "Tim", LastName = "Corey"},
            //    new PersonModel {FirstName = "Sue", LastName = "Storm"},
            //    new PersonModel {FirstName = "Nancy", LastName = "Roman"}
            //};

            //List<EmployeeModel> employees = new List<EmployeeModel>();
            //Accounts accountProcessor = new Accounts();

            //foreach (var person in applicants)
            //{
            //    employees.Add(accountProcessor.Create(person));
            //}

            //foreach (var emp in employees)
            //{
            //    WriteLine(
            //        $"{emp.FirstName} " +
            //        $"{emp.LastName}: " +
            //        $"\t{emp.EmailAddress} ");
            //}


            ///////////////////////////////////////////////////////////////////
            WriteLine("\nEJEMPLO CON FILTROS.-----------------------------\n");

            IList<Cliente> clientes = new Cliente[]
            {
              new Cliente() { Localidad = Localidades.Zaragoza, Nombre = "Joaquin" },
              new Cliente() { Localidad = Localidades.Zaragoza, Nombre = "Antonio" },
              new Cliente() { Localidad = Localidades.Huesca,   Nombre = "Carmen" },
              new Cliente() { Localidad = Localidades.Teruel,   Nombre = "Santiago" }
            };
            FiltroClientes filtrador = new FiltroClientes();
            IEnumerable<Cliente> clientesFiltrados = filtrador.FiltrarPor(
                                                     clientes,
                                                     new FiltroLocalidad(Localidades.Zaragoza));
            foreach (Cliente cli in clientesFiltrados)
            {
                WriteLine(cli.Nombre);
            }

            ///////////////////////////////////////////////////////////////////
            WriteLine("\nFIN.---------------------------------------------\n");

            Write("\nPress enter to close...");
            ReadKey();
        }
    }
}
