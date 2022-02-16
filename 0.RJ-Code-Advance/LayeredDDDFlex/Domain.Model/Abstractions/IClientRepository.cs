using System.Collections.Generic;
using Domain.Model.Entities;

namespace Domain.Model.Abstractions
{
    public interface IClientRepository
    {
        // Comportamientos
        int add(Client client);
        int edit(Client client);
        int remove(Client client);
        IEnumerable<Client> GetClients(string filter);
    }
}
