using System.Windows.Forms;
using Desktop.Controladores;

namespace Desktop.Vistas
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
            _ = new ClienteController(this);
        }
    }
}
