using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video1S
{
    class Program
    {
        static void Main()
        {
            StandardMessages.WelcomeMessage();
            Person user = PersonDataCapture.Capture();
            bool isUserValid = PersonValidator.Validate(user);

            if (isUserValid == false)
            {
                StandardMessages.EndApplication();
            }
            else
            {
                AccountGenerator.CreateAccount(user);
                StandardMessages.EndApplication();
            }
        }
    }
}
