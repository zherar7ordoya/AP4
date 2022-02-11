using System.Windows.Forms;
using ConsultasMVC.Controllers;

namespace ConsultasMVC.Views
{
    public partial class FormularioView : Form
    {
        public FormularioView()
        {
            InitializeComponent();
            ClienteController ctrl = new ClienteController(this);
        }
    }
}
