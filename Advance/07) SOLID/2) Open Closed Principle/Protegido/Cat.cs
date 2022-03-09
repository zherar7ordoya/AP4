using static System.Console;

namespace Protegido
{
    public class Cat : Animal
    {
        public override void Eat()
        {
            WriteLine("Cat says «Give me Whiskas»");
        }

        protected override void ComplexMoving()
        {
            WriteLine("Cat does break-dance");
        }
    }
}

/*
 public override void Eat()
        {
            WriteLine("Cat says namnam");
        }

        /// <summary>
        /// Keyword protected is useful when you want your class and all
        /// derived (child) classes to be able to access the method or variable
        /// but you don't want it to be public.
        /// </summary>
        protected override void ComplexMoving()
        {
            WriteLine("Cat does a slalom");
        } 
 */ 