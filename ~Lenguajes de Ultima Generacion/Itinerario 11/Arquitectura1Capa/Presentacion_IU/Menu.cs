using System;
using System.Windows.Forms;

namespace Presentacion_IU
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OperacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Operaciones ofo = new Operaciones
            {
                MdiParent = this
            };
            ofo.Show();
        }
    }
}
