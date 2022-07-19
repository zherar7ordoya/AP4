namespace Inversión_de_Control_e_Inversión_de_Dependencia
{
    class DAL_Fabrica
    {
        public static DAL_Empleado ObtenerObjeto_DAL_Empleado()
        {
            return new DAL_Empleado();
        }
    }
}
