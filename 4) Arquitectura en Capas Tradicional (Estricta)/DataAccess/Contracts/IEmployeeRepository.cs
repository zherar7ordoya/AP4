using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    internal interface IEmployeeRepository : IGenericRepository<Employees>
    {
        //Ejemplo: obtener todos los empleados por rango de salario.
        IEnumerable<Employees> GetBySalary();
    }
}
