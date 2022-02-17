using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Entities;

namespace Domain.Models.Abstractions
{
    public interface IClientesRepository
    {
        // Comportamientos
        int add(ClientesEntity cliente);
        int edit(ClientesEntity cliente);
        int remove(ClientesEntity cliente);
        IEnumerable<ClientesEntity> GetClients(string filtro);
    }
}
