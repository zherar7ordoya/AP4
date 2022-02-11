using System.Collections.Generic;
using Domain.Model.Abstractions;
using Domain.Model.Entities;
using Infra.DataAccess.Repository;

namespace Aplicacion
{
    public class ClientService
    {
        readonly IClientRepository clientRepository;
        public ClientService()
        {
            clientRepository = new ClientRepository();
        }
        public IEnumerable<Client> GetClients(string filter)
        {
            return clientRepository.GetClients(filter);
        }
    }
}
