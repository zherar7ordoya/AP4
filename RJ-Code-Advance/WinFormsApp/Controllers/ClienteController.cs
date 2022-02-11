
using WinFormsApp.Models.DAO;
using WinFormsApp.Views;

namespace WinFormsApp.Controllers
{
    internal class ClienteController
    {
        readonly ClienteView Vista;

        public ClienteController(ClienteView view)
        {
            Vista = view;
            Vista.Load += new EventHandler(ClientList);
            Vista.cmdBusqueda.Click += new EventHandler(ClientList);
            Vista.tboxFiltrado.TextChanged += new EventHandler(ClientList);
        }

        private void ClientList(object? sender, EventArgs e)
        {
            ClienteDAO db = new ClienteDAO();
            Vista.dgvListado.DataSource = db.VerRegistros(Vista.tboxFiltrado.Text);
        }
    }
}
