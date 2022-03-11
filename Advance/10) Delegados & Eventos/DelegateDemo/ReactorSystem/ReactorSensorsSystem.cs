using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactorSystem
{
    public class ReactorSensorsSystem
    {
        public delegate void NuclearReactorWarningHandler(string message, int currentTemp);

        public static int GetTempFromSensor()
        {
            Random random = new Random();
            // In C# 7.0, the underscore _ may be used as a digit separator. The benefit
            // of this is to improve the code readability when dealing with numbers.
            //return random.Next(1_000);
            return random.Next(101);
        }

        public void CheckReactorTemperature(int temp, NuclearReactorWarningHandler dlg)
        {
            if (temp > 100)
            {
                ApplyCoolingPolicy();
                dlg("Reactor is getting too hot!", temp);
            }
            else
            {
                Console.WriteLine("No worry! Temperature is still OK!");
            }
            //Do other operations.
        }

        private void ApplyCoolingPolicy()
        {
            //Some important stuff ;).
        }
    }
}
