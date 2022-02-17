using System;
using System.Windows.Forms;

namespace App_Registros.UI
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes frm = FormClientes.ObtenerInstancia();
            frm.MdiParent = this;

            // Esta línea está puesta para que el subform cargue
            // maximizado dentro del MDI.
            // FormPrincipal necesita ser WindowsState = Normal.
            frm.WindowState = FormWindowState.Maximized;

            frm.Show();
            frm.BringToFront();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLibros frm = FormLibros.ObtenerInstancia();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
            frm.BringToFront();
        }
    }
}
