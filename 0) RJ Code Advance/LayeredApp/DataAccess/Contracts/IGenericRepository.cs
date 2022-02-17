using System.Collections.Generic;

namespace DataAccess.Contracts
{
    public interface IGenericRepository<Entity> where Entity : class
    {
        int Add(Entity entity);
        int Edit(Entity entity);
        int Remove(int IdPK);
        IEnumerable<Entity> GetAll();
    }
}
