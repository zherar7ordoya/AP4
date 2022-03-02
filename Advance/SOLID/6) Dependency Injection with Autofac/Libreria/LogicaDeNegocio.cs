using static System.Console;

namespace Libreria
{
    public class LogicaDeNegocio : ILogicaDeNegocio
    {
        readonly IRegistrador registrador;
        readonly IAccesoADatos accesoADatos;

        public LogicaDeNegocio(
            IRegistrador registrador,
            IAccesoADatos accesoADatos)
        {
            this.registrador = registrador;
            this.accesoADatos = accesoADatos;
        }

        public void ProcesarDatos()
        {
            registrador.Registrar("Iniciado el procesamiento de datos.");
            WriteLine("Procesando los datos...");
            accesoADatos.CargarDatos();
            accesoADatos.GuardarDatos("información procesada");
            registrador.Registrar("Finalizado el procesamiento de datos.");
        }
    }
}
