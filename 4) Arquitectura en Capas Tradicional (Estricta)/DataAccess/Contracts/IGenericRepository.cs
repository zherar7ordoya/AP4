using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    internal interface IGenericRepository<Entity> where Entity : class
    {
        int Add(Entity entity);
        int Edit(Entity entity);
        int Remove(int idpk);
        IEnumerable<Entity> GetAll();
    }
}
