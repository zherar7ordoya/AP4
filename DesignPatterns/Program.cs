
/// <summary>
/// 
/// En esta soluci�n, se usar�n los siguientes patrones:
/// 
///     SINGLETON:
///     Restringe la instanciaci�n de una clase o valor de un tipo a un solo 
///     objeto (instancia �nica).
///     
///     DATA TRANSFER OBJECT (DTO):
///     Un objeto serializable para la transferencia de datos.
///     
///     DATA ACCESS OBJECT (DAO):
///     Consiste en utilizar un objeto de acceso a datos para abstraer y 
///     encapsular todos los accesos a la fuente de datos. El DAO maneja la 
///     conexi�n con la fuente de datos para obtener y almacenar datos.
///     
/// </summary>


namespace DesignPatterns
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new UI.Desktop.FormularioPrincipal());
        }
    }
}