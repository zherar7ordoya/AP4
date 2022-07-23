using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BLL_Employee BLL_EMPLOYEE = new BLL_Employee();
            BEL_Employee BEL_EMPLOYEE = BLL_EMPLOYEE.GetEmployeeDetails(1);

            Console.WriteLine();
            Console.WriteLine("Employee Details:");
            Console.WriteLine(
                "ID : {0},\n" +
                "Name : {1},\n" +
                "Department : {2},\n" +
                "Salary : {3}",
                BEL_EMPLOYEE.ID,
                BEL_EMPLOYEE.Name,
                BEL_EMPLOYEE.Department,
                BEL_EMPLOYEE.Salary);
            Console.ReadKey();
        }
    }
}
