using System.Collections.Generic;

namespace DataAccess.Contracts
{
    public interface IGenericoRepository<Entity> where Entity : class
    {
        int Agregar(Entity entidad);
        int Eliminar(int id);
        int Modificar(Entity entidad);
        IEnumerable<Entity> Seleccionar();
    }
}
