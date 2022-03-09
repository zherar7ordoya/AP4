using Interface.Desktop.Controllers;
using System.Windows.Forms;

namespace Interface.Desktop.Forms
{
    public partial class ClientesForm : Form
    {
        private ClientesController;
        public ClientesForm()
        {
            InitializeComponent();
            _ = new ClientesController(this);
        }
    }
}
