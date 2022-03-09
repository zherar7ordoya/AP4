using Autofac;
using Libreria;

namespace Consola
{
    public static class Contenedor
    {
        public static IContainer Configurar()
        {
            var fabrica = new ContainerBuilder();

            fabrica.RegisterType<Aplicacion>().As<IAplicacion>();
            fabrica.RegisterType<AccesoADatos>().As<IAccesoADatos>();
            fabrica.RegisterType<LogicaDeNegocio>().As<ILogicaDeNegocio>();
            fabrica.RegisterType<Registrador>().As<IRegistrador>();

            return fabrica.Build();
        }
    }
}
