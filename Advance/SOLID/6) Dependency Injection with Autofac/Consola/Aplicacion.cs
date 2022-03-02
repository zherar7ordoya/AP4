using Libreria;

namespace Consola
{
    public class Aplicacion : IAplicacion
    {
        readonly ILogicaDeNegocio logicaDeNegocio;

        public Aplicacion(ILogicaDeNegocio logicaDeNegocio)
        {
            this.logicaDeNegocio = logicaDeNegocio;
        }

        public void Ejecutar()
        {
            logicaDeNegocio.ProcesarDatos();
        }
    }
}
