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
            Console.WriteLine("DETALLES DE EMPLEADO");

            Console.WriteLine(
                "\tId\t\t{0}\n" +
                "\tNombre\t\t{1}\n" +
                "\tDepartmento\t{2}\n" +
                "\tSueldo\t\t{3}",
                BEL_EMPLEADO.Id,
                    BEL_EMPLEADO.Nombre,
                    BEL_EMPLEADO.Departmento,
                    BEL_EMPLEADO.Sueldo);

            Console.ReadKey();
        }
    }
}
