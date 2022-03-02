using static System.Console;

namespace Protegido
{
    public class Dog : Animal
    {
        public override void Eat()
        {
            WriteLine("Dog says Namnam");
        }

        protected override void ComplexMoving()
        {
            WriteLine("Dog no stupid");
        }
    }
}
