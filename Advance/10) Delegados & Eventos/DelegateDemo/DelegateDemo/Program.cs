using ReactorSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static DelegateDemo.Program;

namespace DelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hellow from DelegateDemo project!");

            var wSystem = new ReactorSensorsSystem();
            var isWeekend = DateTime.Now.DayOfWeek == DayOfWeek.Saturday || DateTime.Now.DayOfWeek == DayOfWeek.Sunday;

            while(true)
            {
                Thread.Sleep(1000);
                int temp = ReactorSensorsSystem.GetTempFromSensor();
                if (isWeekend)
                {
                    //  if today date is weekend date, we pass our method “SendWarningSMS”
                    //  to the reactor sensors’ system method CheckReactorTemperature().
                    //  Note, that this method is not static, so it requires an instance
                    //  of a “Program” object (so we create one first).
                    wSystem.CheckReactorTemperature(temp, (new Program()).SendWarningSMS);
                }
                else
                {
                    // on a week day, we pass our method “SendWarningEmail”
                    // to the reactor sensors’ system method
                    // CheckReactorTemperature().
                    // Note, that this method is static, so there is no need
                    // to create an instance of any class.
                    wSystem.CheckReactorTemperature(temp, SendWarningEmail);
                }
            }
        }

        public static void SendWarningEmail(string message, int currentTemp)
        {
            string emailMsg = message + $"Temperate has changed! Now it equals {currentTemp}";

            //Logic for sending email.
            Console.WriteLine($"Email sent! The message was: \n {emailMsg}");
        }

        public void SendWarningSMS(string message, int currentTemp)
        {
            string emailMsg = message + $"Temperate has changed! Now it equals {currentTemp}";

            //Logic for texting users.
            Console.WriteLine($"SMS sent! The message was: \n {emailMsg}");
        }
    }
}
