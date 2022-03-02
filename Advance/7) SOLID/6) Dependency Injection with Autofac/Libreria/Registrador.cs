using static System.Console;

namespace Libreria
{
    public class Registrador : IRegistrador
    {
        public void Registrar(string mensaje)
        {
            WriteLine($"\nRegistrando: { mensaje }\n");
        }
    }
}
