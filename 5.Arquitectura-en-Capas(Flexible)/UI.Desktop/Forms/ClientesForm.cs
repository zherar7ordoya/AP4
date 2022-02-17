using System.Windows.Forms;
using UI.Desktop.Controllers;

namespace UI.Desktop.Forms
{
    public partial class ClientesForm : Form
    {
        private ClientesController clientes;
        public ClientesForm()
        {
            InitializeComponent();
            clientes = new ClientesController();
        }

        private void ClientesForm_Load(object sender, System.EventArgs e)
        {
            dgvClientes.DataSource = clientes.GetClientesAll(string.Empty);
        }

        private void tboxFiltrar_TextChanged(object sender, System.EventArgs e)
        {
            dgvClientes.DataSource = clientes.GetClientesAll(tboxFiltrar.Text);
        }
    }
}
