using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleUI
{
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandardMesssages.DisplayValidationError("first name");
                return false;   
            }
            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMesssages.DisplayValidationError("last name");
                return false;
            }
            return true;
        }
    }
}
