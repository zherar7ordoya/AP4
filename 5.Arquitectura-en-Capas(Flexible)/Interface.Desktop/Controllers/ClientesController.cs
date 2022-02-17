using Interface.Desktop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Services;
using Domain.Models.Entities;

namespace Interface.Desktop.Controllers
{
    internal class ClientesController
    {
        public IEnumerable<ClientesViewModel> GetClientesAll(string filtro)
        {
            var listaClientes = new ClientesService().GetClientes(filtro);
            List<ClientesViewModel> clientesViewModel = new List<ClientesViewModel>();

            foreach (ClientesEntity item in listaClientes)
            {
                clientesViewModel.Add(new ClientesViewModel
                {
                    ID = item.ID,
                    Nombre = item.Nombre,
                    Apellido = item.Apellido,
                    Direccion = item.Direccion,
                    Ciudad = item.Ciudad,
                    Email = item.Email,
                    Telefono = item.Telefono,
                    Ocupacion = item.Ocupacion
                });
            }
            return clientesViewModel;
        }
    }
}
