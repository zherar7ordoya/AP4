using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Entities;

namespace Domain.Models.Abstractions
{
    public interface IClienteRepository
    {
        // Comportamientos
        int add(Cliente cliente);
        int edit(Cliente cliente);
        int remove(Cliente cliente);
        IEnumerable<Cliente> GetClients(string filtro);
    }
}
