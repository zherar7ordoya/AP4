using System;
using ConsultasMVC.Models.DAO;
using ConsultasMVC.Views;

namespace ConsultasMVC.Controllers
{
    internal class ClienteController
    {
        readonly FormularioView Vista;

        // *-----------------------------------------------------=> Constructor
        public ClienteController(FormularioView view)
        {
            Vista = view;

            // Inicializar eventos
            Vista.Load += new EventHandler(ClientList);
            Vista.btnBuscar.Click += new EventHandler(ClientList);
            Vista.txtBuscar.TextChanged += new EventHandler(ClientList);
        }
        // *---------------------------------------------------------------=> *

        private void ClientList(object sender, EventArgs e)
        {
            ClienteDAO db = new ClienteDAO();
            Vista.dgvClientes.DataSource = db.VerRegistros(Vista.txtBuscar.Text);
        }
    }
}
