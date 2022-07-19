namespace Inversión_de_Control_e_Inversión_de_Dependencia
{
    public class BLL_Empleado
    {
        IDAL_Empleado DAL_EMPLEADO; // PASO 2 - CAMBIO 3/3

        public BLL_Empleado()
        {
            DAL_EMPLEADO = DAL_Fabrica.ObtenerDALEmpleado();
        }

        public BEL_Empleado ObtenerDetallesEmpleado(int id)
        {
            return DAL_EMPLEADO.ObtenerDetallesEmpleado(id);
        }
    }
}
