using System;
using static System.Console;
using Video3LLibrary;

namespace Video3LConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager accountingVP = new Manager
            {
                FirstName = "Emma",
                LastName = "Stone"
            };
            accountingVP.CalculatePerHourRate(4);

            Employee emp = new Manager
            {
                FirstName = "Tim",
                LastName = "Corey"
            };
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour.");

            ReadKey();
        }
    }
}
