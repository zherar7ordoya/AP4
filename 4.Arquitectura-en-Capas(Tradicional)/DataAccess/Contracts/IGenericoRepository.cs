using System.Collections.Generic;

namespace DataAccess.Contracts
{
    internal interface IGenericoRepository<Entity> where Entity : class
    {
        int Add(Entity entity);
        int Edit(Entity entity);
        int Remove(int idpk);
        IEnumerable<Entity> GetAll();
    }
}
