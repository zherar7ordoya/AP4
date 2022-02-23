using DataAccess.Entities;
using System.Collections.Generic;

namespace DataAccess.Contracts
{
    /// <summary>
    /// 
    /// Recordemos que una interfaz es 100% abstracta y que es implementada por
    /// una clase concreta.
    /// Aquí, en esta interfaz, podemos tener otros métodos (ver ejemplo).
    /// 
    /// Pero si las entidades solo necesitan los 4 métodos básicos CRUD, en ese
    /// caso se puede implementar directamente el repositorio genérico.
    /// 
    /// </summary>
    public interface IEmpleadosRepository : IGenericoRepository<Empleados>
    {
        //Ejemplo: obtener todos los empleados por rango de salario.
        IEnumerable<Empleados> SeleccionarPorSueldo();
    }
}
