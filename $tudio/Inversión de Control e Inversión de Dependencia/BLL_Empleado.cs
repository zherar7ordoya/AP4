namespace Inversión_de_Control_e_Inversión_de_Dependencia
{
    public class BLL_Empleado
    {
        DAL_Empleado DAL_EMPLEADO;

        public BLL_Empleado()
        {
            DAL_EMPLEADO = DAL_Fabrica.ObtenerObjeto_DAL_Empleado();
        }

        public BEL_Empleado ObtenerDetallesEmpleado(int id)
        {
            return DAL_EMPLEADO.ObtenerDetallesEmpleado(id);
        }
    }
}
