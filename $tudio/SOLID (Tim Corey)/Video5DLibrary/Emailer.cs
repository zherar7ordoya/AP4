using System;

namespace Video5DLibrary
{
    /// <summary>
    /// 
    /// MÓDULO DE BAJO NIVEL
    /// 
    /// EMAILER depende de nadie, es pues, un módulo de bajo nivel.
    /// </summary>
    public class Emailer
    {
        public void SendEmail(IPerson person, string message)
        {
            Console.WriteLine($"Simulating sending an email to {person.EmailAddress}");
        }
    }


}
