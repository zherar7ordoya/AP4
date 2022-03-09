using Filtro;
using Protegido;
using System.Collections.Generic;
using static System.Console;
using OCPLibrary;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////
            WriteLine("\nEJEMPLO ORIGINAL.--------------------------------\n");

            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel {FirstName = "Tim", LastName = "Corey"},
                new ManagerModel {FirstName = "Sue", LastName = "Storm"},
                new ExecutiveModel {FirstName = "Nancy", LastName = "Roman"}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var person in applicants)
            {
                employees
                    .Add(person.AccountProcessor
                    .Create(person));
            }

            foreach (var emp in employees)
            {
                WriteLine(
                    $"{emp.FirstName} " +
                    $"{emp.LastName}: " +
                    $"{emp.EmailAddress} " +
                    (emp.IsManager ? "\tMANAGER" : string.Empty) +
                    (emp.IsExecutive ? "\tEXECUTIVE" : string.Empty));
            }

            ///////////////////////////////////////////////////////////////////
            WriteLine("\nEJEMPLO CON FILTROS.-----------------------------\n");

            IList<Cliente> clientes = new Cliente[]
            {
              new Cliente() { Localidad = Localidades.Zaragoza, Nombre = "Joaquin" },
              new Cliente() { Localidad = Localidades.Jujuy,    Nombre = "Gerardo" },
              new Cliente() { Localidad = Localidades.Zaragoza, Nombre = "Antonio" },
              new Cliente() { Localidad = Localidades.Huesca,   Nombre = "Carmen" },
              new Cliente() { Localidad = Localidades.Teruel,   Nombre = "Santiago" }
            };
            FiltroClientes filtrador = new FiltroClientes();
            IEnumerable<Cliente> clientesFiltrados = filtrador.FiltrarPor(
                                                     clientes,
                                                     new FiltroLocalidad(Localidades.Jujuy));
            foreach (Cliente cli in clientesFiltrados)
            {
                WriteLine(cli.Nombre);
            }
            WriteLine("NOTA: no está completamente implementado. Una lástima...");

            ///////////////////////////////////////////////////////////////////
            WriteLine("\nEJEMPLO PARA MÉTODO PROTEGIDO.-------------------\n");

            Animal cat = new Cat();
            Animal dog = new Dog();
            cat.Eat();
            dog.Eat();
            cat.Move();
            dog.Move();

            ///////////////////////////////////////////////////////////////////
            WriteLine("\nFIN.---------------------------------------------\n");

            Write("\nPress enter to close...");
            ReadKey();
        }
    }
}
