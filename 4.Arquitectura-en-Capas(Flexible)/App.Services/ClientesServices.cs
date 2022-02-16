using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Abstractions;
using Domain.Models.Entities;
using Infra.DataAccess.Repository;


namespace App.Services
{
    internal class ClientesServices
    {
        readonly IClienteRepository clientesRepository;
        public ClientesServices()
        {
            clientesRepository = new ClienteRepository();
        }
        public IEnumerable<Cliente> GetClients(string filtro)
        {
            return clientesRepository.GetClients(filtro);
        }
    }
}
