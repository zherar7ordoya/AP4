using System;
using System.Windows.Forms;

namespace EscritorioClasico.ABMs
{
    public partial class ClientesForm : Form
    {
        // *-------------------------------------------------------=> SINGLETON
        private ClientesForm()
        {
            InitializeComponent();
        }
        private static ClientesForm instancia = null;
        public static ClientesForm Instancia()
        {
            if (instancia == null) instancia = new ClientesForm();
            return instancia;
        }
        // *-------------------------------------------------------=> *********
        private void AltaClienteButton_Click(object sender, EventArgs e)
        {
            ClienteForm formulario = ClienteForm.Instancia();
            DialogResult respuesta = formulario.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                MessageBox.Show("DialogResult: OK");
            }
        }

        private void ClientesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
