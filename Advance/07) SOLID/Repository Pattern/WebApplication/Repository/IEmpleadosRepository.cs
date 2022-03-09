using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Repository
{
    public interface IEmpleadosRepository
    {
        IEnumerable<Empleados> ObtenerTodos();
        Empleados ObtenerPorId(int id);
        void Agregar(Empleados empleado);
        void Modificar(Empleados empleado);
        void Eliminar(int id);
        void Guardar();
    }
}
