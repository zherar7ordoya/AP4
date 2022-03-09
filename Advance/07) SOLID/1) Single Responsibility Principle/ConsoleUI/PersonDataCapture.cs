using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleUI
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            Person output = new Person();

            Write("First name: ");
            output.FirstName = ReadLine();

            Write("Last name: ");
            output.LastName = ReadLine();

            return output;
        }
    }
}
