using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleUI
{
    public class StandardMesssages
    {
        public static void WelcomeMessage()
        {
            WriteLine("Welcome to my application!");
        }

        public static void EndApplication()
        {
            Write("Press enter to close...");
            ReadKey();
        }

        public static void DisplayValidationError(string fieldName)
        {
            WriteLine($"You did no give us a valid {fieldName}!");
        }
    }
}
