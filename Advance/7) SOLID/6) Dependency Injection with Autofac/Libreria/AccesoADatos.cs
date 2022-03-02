using static System.Console;

namespace Libreria
{
    public class AccesoADatos : IAccesoADatos
    {
        public void CargarDatos()
        {
            WriteLine("Cargando datos...");
        }
        public void GuardarDatos(string mensaje)
        {
            WriteLine($"Guardando { mensaje }...");
        }
    }
}
