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
    public class ClientesService
    {
        readonly IClientesRepository clientesRepository;
        public ClientesService()
        {
            clientesRepository = new ClientesRepository();
        }
        public IEnumerable<ClientesEntity> GetClientes(string filtro)
        {
            return clientesRepository.GetClients(filtro);
        }
    }
}
