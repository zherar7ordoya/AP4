using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inversión_de_Control_e_Inversión_de_Dependencia
{
    public interface IDAL_Empleado
    {
        BEL_Empleado ObtenerDetallesEmpleado(int id);
    }
}
