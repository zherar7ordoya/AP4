using System.Windows.Forms;

namespace Bodega
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ProveedoresToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ListadoForm x = new ListadoForm();
            x.MdiParent = this;
            x.Show();
        }
    }
}
