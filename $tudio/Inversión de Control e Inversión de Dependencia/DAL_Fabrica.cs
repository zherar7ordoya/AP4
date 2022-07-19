namespace Inversión_de_Control_e_Inversión_de_Dependencia
{
    class DAL_Fabrica
    {
        public static IDAL_Empleado ObtenerDALEmpleado() // PASO 2 - CAMBIO 2/3
        {
            return new DAL_Empleado();
        }
    }
}
