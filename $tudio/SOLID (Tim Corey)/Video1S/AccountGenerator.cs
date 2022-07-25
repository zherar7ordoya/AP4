using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Video1S
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            WriteLine(
                "Your username is " +
                $"{user.FirstName.Substring(0, 1).ToLower()}" +
                $"{user.LastName.ToLower()}");
        }
    }
}
