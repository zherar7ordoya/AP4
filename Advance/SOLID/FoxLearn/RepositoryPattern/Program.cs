using Autofac;

namespace RepositoryPattern
{
    internal static class Program
    {
        public static IContainer Container;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Container = Configure();
            Application.Run(new Form1(Container.Resolve<IProductRepository>()));
        }

        /// <summary>
        /// Setting dependenct injection
        /// </summary>
        /// <returns></returns>
        static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<Form1>();
            return builder.Build();
        }
    }
}