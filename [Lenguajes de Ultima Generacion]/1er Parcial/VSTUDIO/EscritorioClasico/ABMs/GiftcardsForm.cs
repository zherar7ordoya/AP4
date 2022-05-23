using System;
using System.Data;
using System.Windows.Forms;

namespace EscritorioClasico.ABMs
{
    public partial class GiftcardsForm : Form
    {
        //APP-1
        BLL.TarjetaInternacional internacional;
        BLL.TarjetaNacional nacional;

        // *-------------------------------------------------------=> SINGLETON
        private GiftcardsForm()
        {
            InitializeComponent();

            //APP-2
            internacional = new BLL.TarjetaInternacional();
            nacional = new BLL.TarjetaNacional();
        }

        private static GiftcardsForm instancia = null;

        public static GiftcardsForm Instancia()
        {
            if (instancia == null) instancia = new GiftcardsForm();
            return instancia;
        }

        private void AltaGitfcardButton_Click(object sender, EventArgs e)
        {
            GiftcardForm formulario = GiftcardForm.Instancia();
            DialogResult respuesta = formulario.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                MessageBox.Show("DialogResult: OK");
            }
        }

        private void GiftcardsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
        // *-------------------------------------------------------=> *********


        //APP-3
        private void GiftcardsForm_Load(object sender, EventArgs e)
        {
            this.InternacionalesDataGridView.DataSource = null;
            this.InternacionalesDataGridView.Rows.Clear();
            this.InternacionalesDataGridView.DataSource = internacional.Listar();

            this.NacionalesDataGridView.DataSource = null;
            this.NacionalesDataGridView.Rows.Clear();
            this.NacionalesDataGridView.DataSource = nacional.Listar();
        }

        private void InternacionalesDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0) MessageBox.Show(InternacionalesDataGridView[(e.ColumnIndex + 3), e.RowIndex].Value.ToString() + ": estás a punto de borrar.");
                if (e.ColumnIndex == 1) MessageBox.Show(InternacionalesDataGridView[(e.ColumnIndex + 2), e.RowIndex].Value.ToString() + ": vas a editar...");
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

        private void NacionalesDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0) MessageBox.Show(NacionalesDataGridView[(e.ColumnIndex + 3), e.RowIndex].Value.ToString() + ": estás a punto de borrar.");
                if (e.ColumnIndex == 1) MessageBox.Show(NacionalesDataGridView[(e.ColumnIndex + 2), e.RowIndex].Value.ToString() + ": vas a editar...");
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
