using LinqLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = ListManager.LoadSampleData();

            //people = people.OrderByDescending(x => x.LastName).ThenBy(x => x.YearsExperience).ToList();
            //people = people.Where(x => x.YearsExperience > 9 && x.Birthday.Month == 3).ToList();

            //foreach (var person in people)
            //{
            //    Console.WriteLine($"{ person.FirstName } { person.LastName } ({ person.Birthday.ToShortDateString() }): Experience { person.YearsExperience }");
            //}

            //int yearsTotal = people.Sum(x => x.YearsExperience);
            int yearsTotal = people.Where(x=>x.Birthday.Month==3).Sum(x => x.YearsExperience);
            Console.WriteLine($"The total years experience is {yearsTotal}");

            Console.ReadLine();
        }
    }
}
