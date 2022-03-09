using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Models;

namespace WebApplication.Repository
{
    public class EmpleadosRepository : IEmpleadosRepository
    {
        private RJCodeAdvanceEntities ObjetoRJCodeAdvanceEntities;

        // *-----------------------------------------=> Constructores
        public EmpleadosRepository()
        {
            ObjetoRJCodeAdvanceEntities = new RJCodeAdvanceEntities();
        }

        public EmpleadosRepository(RJCodeAdvanceEntities objetoRJCodeAdvanceEntities)
        {
            ObjetoRJCodeAdvanceEntities = objetoRJCodeAdvanceEntities;
        }

        // *-----------------------------------------------=> Métodos

        public void Agregar(Empleados empleado)
        {
            ObjetoRJCodeAdvanceEntities.Empleados.Add(empleado);
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar()
        {
            ObjetoRJCodeAdvanceEntities.SaveChanges();
        }

        public void Modificar(Empleados empleado)
        {
            throw new NotImplementedException();
        }

        public Empleados ObtenerPorId(int id)
        {
            return ObjetoRJCodeAdvanceEntities.Empleados.Single(modelo => modelo.id == id);
        }

        public IEnumerable<Empleados> ObtenerTodos()
        {
            return ObjetoRJCodeAdvanceEntities.Empleados;
        }
    }
}