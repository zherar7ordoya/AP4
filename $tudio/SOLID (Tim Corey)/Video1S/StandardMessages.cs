using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Video1S
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            WriteLine("Welcome to my app!");
        }

        public static void EndApplication()
        {
            WriteLine("Press enter to close...");
            ReadLine();
        }

        public static void DisplayValidationError(string fieldName)
        {
            WriteLine($"You did not give us a valid {fieldName}");
        }
    }
}
