using WinFormsApp.Controllers;

namespace WinFormsApp.Views
{
    public partial class ClienteView : Form
    {
        public ClienteView()
        {
            InitializeComponent();
            ClienteController CTRL = new(this);
        }
    }
}
