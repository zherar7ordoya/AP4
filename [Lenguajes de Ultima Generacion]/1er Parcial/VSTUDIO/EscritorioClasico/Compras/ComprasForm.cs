using System;
using System.Data;
using System.Windows.Forms;

namespace EscritorioClasico.Compras
{
    public partial class ComprasForm : Form
    {
        //APP-1
        BLL.Cliente cliente;

        // *-------------------------------------------------------=> SINGLETON
        private ComprasForm()
        {
            InitializeComponent();

            //APP-2
            cliente = new BLL.Cliente();
        }
        private static ComprasForm instancia = null;
        public static ComprasForm Instancia()
        {
            if (instancia == null) instancia = new ComprasForm();
            return instancia;
        }

        private void AltaCompraButton_Click(object sender, EventArgs e)
        {
            CompraForm formulario = CompraForm.Instancia();
            DialogResult respuesta = formulario.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                MessageBox.Show("DialogResult: OK");
            }
        }

        private void ComprasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
        // *-------------------------------------------------------=> *********


        //APP-3
        private void ComprasForm_Load(object sender, EventArgs e)
        {
            this.ComprasDataGridView.DataSource = null;
            this.ComprasDataGridView.Rows.Clear();
            this.ComprasDataGridView.DataSource = cliente.Listar();
        }

        private void ComprasDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0) MessageBox.Show(ComprasDataGridView[(e.ColumnIndex + 3), e.RowIndex].Value.ToString() + ": estás a punto de borrar.");
                if (e.ColumnIndex == 1) MessageBox.Show(ComprasDataGridView[(e.ColumnIndex + 2), e.RowIndex].Value.ToString() + ": vas a editar...");
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
