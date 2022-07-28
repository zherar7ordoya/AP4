using System;
using Video5DLibrary;

namespace Video5DConsole
{
    class Program
    {
        /// <summary>
        /// 
        /// MÓDULO DE ALTO NIVEL
        /// 
        /// MAIN es un módulo de alto nivel que llama a PERSON y a CHORE.
        /// Es decir, MAIN depende de esas dos clases.
        /// Por tanto, esas dos clases son sus dependencias.
        /// </summary>
        static void Main()
        {
            IPerson owner = new Person
            {
                FirstName = "Tim",
                LastName = "Corey",
                EmailAddress = "tim@iamtimcorey.com",
                PhoneNumber = "555-1212"
            };

            Chore chore = new Chore
            {
                ChoreName = "Take out the trash",
                Owner = owner
            };

            chore.PerformedWork(3);
            chore.PerformedWork(1.5);
            chore.CompleteChore();

            Console.ReadLine();
        }
    }
}
