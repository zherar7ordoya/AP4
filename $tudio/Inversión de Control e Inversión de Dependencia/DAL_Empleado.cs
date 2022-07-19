namespace Inversión_de_Control_e_Inversión_de_Dependencia
{
    public class DAL_Empleado
    {
        public BEL_Empleado ObtenerDetallesEmpleado(int id)
        {
            // En "real-time" los datos se obtendrían de una base de datos.
            // Pero para este ejemplo, los detalles de empleado se ofrecen
            // merced a una codificación fija (hard-coded).
            BEL_Empleado empleado = new BEL_Empleado()
            {
                Id = id,
                Nombre = "Gerardo",
                Departmento = "Facturación",
                Sueldo = 10000
            };
            return empleado;
        }
    }
}
