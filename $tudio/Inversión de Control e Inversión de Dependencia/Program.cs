using System;

namespace Inversión_de_Control_e_Inversión_de_Dependencia
{
    class Program
    {
        static void Main(string[] args)
        {
            BLL_Empleado BLL_EMPLEADO = new BLL_Empleado();
            BEL_Empleado BEL_EMPLEADO = BLL_EMPLEADO.ObtenerDetallesEmpleado(1);

            Console.WriteLine();
            Console.WriteLine("Detalles de Empleado:");

            Console.WriteLine(
                "Id: {0}, " +
                "Nombre: {1}, " +
                "Departmento: {2}, " +
                "Sueldo : {3}",
                BEL_EMPLEADO.Id,
                    BEL_EMPLEADO.Nombre,
                    BEL_EMPLEADO.Departmento,
                    BEL_EMPLEADO.Sueldo);

            Console.ReadKey();
        }
    }
}
