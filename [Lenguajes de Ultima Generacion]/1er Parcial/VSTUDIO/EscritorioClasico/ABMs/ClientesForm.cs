using System;
using System.Data;
using System.Windows.Forms;

namespace EscritorioClasico.ABMs
{
    public partial class ClientesForm : Form
    {
        //APP-1
        BLL.Cliente cliente;

        // *-------------------------------------------------------=> SINGLETON
        private static ClientesForm instancia = null;

        private ClientesForm()
        {
            InitializeComponent();

            //APP-2
            cliente = new BLL.Cliente(); 
        }

        public static ClientesForm Instancia()
        {
            if (instancia == null) instancia = new ClientesForm();
            return instancia;
        }

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
        // *-------------------------------------------------------=> *********


        //APP-3
        private void ClientesForm_Load(object sender, EventArgs e)
        {
            this.ClientesDataGridView.DataSource = null;
            this.ClientesDataGridView.Rows.Clear();
            this.ClientesDataGridView.DataSource = cliente.Listar();
        }

        private void ClientesDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0) MessageBox.Show(ClientesDataGridView[(e.ColumnIndex + 3), e.RowIndex].Value.ToString() + ": estás a punto de borrar.");
                if (e.ColumnIndex == 1) MessageBox.Show(ClientesDataGridView[(e.ColumnIndex + 2), e.RowIndex].Value.ToString() + ": vas a editar...");
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                string caption = "Informe de Excepciones";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
            }
        }


        
    }
}
