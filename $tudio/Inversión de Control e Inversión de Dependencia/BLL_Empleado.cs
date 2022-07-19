namespace Inversión_de_Control_e_Inversión_de_Dependencia
{
    public class BLL_Empleado
    {
        IDAL_Empleado DAL_EMPLEADO; // PASO 2 - CAMBIO 3/3

        // PASO 3 - La inyección de constructor
        public BLL_Empleado(IDAL_Empleado dal)
        {
            DAL_EMPLEADO = dal;
        }

        public BEL_Empleado ObtenerDetallesEmpleado(int id)
        {
            return DAL_EMPLEADO.ObtenerDetallesEmpleado(id);
        }
    }
}
