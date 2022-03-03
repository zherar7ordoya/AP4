using System.Windows.Forms;

namespace Bodega
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void proveedorToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ProveedorForm x = new ProveedorForm();
            x.MdiParent = this;
            x.Show();
        }
    }
}
