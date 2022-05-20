using System;
using System.Data;
using System.Windows.Forms;

namespace EscritorioClasico.Compras
{
    public partial class ComprasForm : Form
    {
        // *-------------------------------------------------------=> SINGLETON
        private ComprasForm()
        {
            InitializeComponent();
        }
        private static ComprasForm instancia = null;
        public static ComprasForm Instancia()
        {
            if (instancia == null) instancia = new ComprasForm();
            return instancia;
        }
        private void ComprasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
        // *-------------------------------------------------------=> *********

        private void AltaCompraButton_Click(object sender, EventArgs e)
        {
            CompraForm formulario = CompraForm.Instancia();
            DialogResult respuesta = formulario.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                MessageBox.Show("DialogResult: OK");
            }
        }

        #region DUMMY DATA
        private void ComprasForm_Load(object sender, EventArgs e)
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
            ComprasDataGridView.DataSource = null;
            ComprasDataGridView.DataSource = datos.Tables[0].DefaultView;
        }

        private void ComprasDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0) MessageBox.Show(ComprasDataGridView[(e.ColumnIndex + 3), e.RowIndex].Value.ToString() + ": estás a punto de borrar.");
                if (e.ColumnIndex == 1) MessageBox.Show(ComprasDataGridView[(e.ColumnIndex + 2), e.RowIndex].Value.ToString() + ": vas a editar...");
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}
