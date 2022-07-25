﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Video2OLibrary;

namespace Video2OConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            List<PersonModel> applicants = new List<PersonModel>

            {
                new PersonModel{FirstName="Tim", LastName="Corey"},
                new PersonModel{FirstName="Sue", LastName="Storm", TypeOfEmployee=EmployeeType.Manager},
                new PersonModel{FirstName="Nancy", LastName="Roman", TypeOfEmployee=EmployeeType.Executive},
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            foreach (var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine(
                    $"{emp.FirstName} " +
                    $"{emp.LastName}: " +
                    $"{emp.EmailAddress} " +
                    $"\tIsManager: {emp.IsManager} " +
                    $"\tIsExecutive: {emp.IsExecutive}");
            }

            Console.ReadKey();
        }
    }
}
