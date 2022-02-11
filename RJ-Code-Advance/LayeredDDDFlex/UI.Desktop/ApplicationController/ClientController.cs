using System.Collections.Generic;

using Domain.Model.Entities;
using Aplicacion;
using UI.Desktop.ViewModel;

namespace UI.Desktop.ApplicationController
{
    internal class ClientController
    {
        public IEnumerable<ClientViewModel> GetClientsAll(string filter)
        {
            var clientList = new ClientService().GetClients(filter);
            List<ClientViewModel> viewModel = new List<ClientViewModel>();

            foreach(Client item in clientList)
            {
                viewModel.Add(new ClientViewModel
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
            return viewModel;
        }
    }
}
