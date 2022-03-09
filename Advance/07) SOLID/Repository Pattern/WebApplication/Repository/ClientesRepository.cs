using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication.Models;

namespace WebApplication.Repository
{
    public class ClientesRepository : IClientesRepository
    {
        private RJCodeAdvanceEntities ObjetoRJCodeAdvanceEntities;

        public ClientesRepository()
        {
            ObjetoRJCodeAdvanceEntities = new RJCodeAdvanceEntities();
        }

        public ClientesRepository(RJCodeAdvanceEntities objetoRJCodeAdvanceEntities)
        {
            ObjetoRJCodeAdvanceEntities = objetoRJCodeAdvanceEntities;
        }

        /*---------------------------------*/

        public void Agregar(Clientes cliente)
        {
            ObjetoRJCodeAdvanceEntities.Clientes.Add(cliente);
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void Guardar()
        {
            ObjetoRJCodeAdvanceEntities.SaveChanges();
        }

        public void Modificar(Clientes cliente)
        {
            throw new NotImplementedException();
        }

        public Clientes ObtenerPorId(int id)
        {
            return ObjetoRJCodeAdvanceEntities.Clientes.Single(x => x.ID == id);
        }

        public IEnumerable<Clientes> ObtenerTodos()
        {
            return ObjetoRJCodeAdvanceEntities.Clientes;
        }
    }
}