using static System.Console;
using Autofac;

namespace Consola
{
    internal class Program
    {
        static void Main()
        {
            var contenedor = Contenedor.Configurar();

            using(var alcance = contenedor.BeginLifetimeScope())
            {
                var aplicacion = alcance.Resolve<IAplicacion>();
                aplicacion.Ejecutar();
            }

            ///////////////////////////////////////////////////////////////////
            ReadKey();
        }
    }
}
