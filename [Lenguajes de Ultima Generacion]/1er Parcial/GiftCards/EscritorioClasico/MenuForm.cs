using System;
using System.Windows.Forms;

namespace EscritorioClasico
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            Usuarios.UsuarioForm formulario = new Usuarios.UsuarioForm();
            formulario.MdiParent = this;
            formulario.Dock = DockStyle.Fill;
            formulario.Show();
            formulario.WindowState = FormWindowState.Maximized;
            formulario.BringToFront();
        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMs.ClientesForm formulario = ABMs.ClientesForm.Instancia();
            formulario.MdiParent = this;
            formulario.Show();
            formulario.BringToFront();
        }

        private void GiftCardsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMs.GiftcardsForm formulario = ABMs.GiftcardsForm.Instancia();
            formulario.MdiParent = this;
            formulario.Show();
            formulario.BringToFront();
        }

        private void AsociarDesasociarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteGiftcard.ClienteGiftcardForm formulario = ClienteGiftcard.ClienteGiftcardForm.Instancia();
            formulario.MdiParent = this;
            formulario.Show();
            formulario.BringToFront();
        }

        private void RegistrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Compras.ComprasForm formulario = Compras.ComprasForm.Instancia();
            formulario.MdiParent = this;
            formulario.Show();
            formulario.BringToFront();
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Parcial 1\n\u00a9 2022 LUG";
            string caption = "Acerca de";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(
                this, 
                message, 
                caption, 
                buttons,
                MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign);

        }
    }
}
