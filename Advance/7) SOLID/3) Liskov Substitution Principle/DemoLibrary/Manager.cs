using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DemoLibrary
{
    public class Manager : Employee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 19.75M;
            Salary = baseAmount + (rank * 4);
        }

        public void GeneratePerformanceReview()
        {
            WriteLine("Reviewing a report's performance...");
        }
    }
}
