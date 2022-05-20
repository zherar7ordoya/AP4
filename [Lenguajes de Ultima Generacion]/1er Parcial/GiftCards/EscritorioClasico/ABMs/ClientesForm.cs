using System;
using System.Data;
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
        private void ClientesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
        // *-------------------------------------------------------=> *********

        #region DUMMY DATA
        private void ClientesForm_Load(object sender, EventArgs e)
        {
            DataSet datos = new DataSet();
            DataTable tabla = new DataTable();

            tabla.Columns.Add("Código");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Apellido");

            tabla.Rows.Add(new object[]
            {
                777,
                "Gerardo",
                "Tordoya"
            });
            tabla.Rows.Add(new object[]
            {
                987,
                "Alfredo",
                "Mamaní"
            });

            datos.Tables.Add(tabla);
            ClientesDataGridView.DataSource = null;
            ClientesDataGridView.DataSource = datos.Tables[0].DefaultView;
        }
        private void ClientesDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0) MessageBox.Show(ClientesDataGridView[(e.ColumnIndex + 3), e.RowIndex].Value.ToString() + ": estás a punto de borrar.");
                if (e.ColumnIndex == 1) MessageBox.Show(ClientesDataGridView[(e.ColumnIndex + 2), e.RowIndex].Value.ToString() + ": vas a editar...");
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        private void AltaClienteButton_Click(object sender, EventArgs e)
        {
            ClienteForm formulario = ClienteForm.Instancia();
            DialogResult respuesta = formulario.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                MessageBox.Show("DialogResult: OK");
            }
        }
    }
}
