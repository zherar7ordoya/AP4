using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DemoLibrary
{
    public class CEO : BaseEmployee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;
            Salary = baseAmount * rank;
        }

        public void GeneratePerformanceReview()
        {
            WriteLine("Reviewing a report's performance...");
        }

        public void FireSomeone()
        {
            WriteLine("Don't wanna do it...");
        }
    }
}
