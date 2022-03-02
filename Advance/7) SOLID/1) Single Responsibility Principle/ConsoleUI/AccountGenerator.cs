using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleUI
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            WriteLine(value: $"Your user name is {user.FirstName.Substring(0, 1)}{user.LastName}");
        }
    }
}
