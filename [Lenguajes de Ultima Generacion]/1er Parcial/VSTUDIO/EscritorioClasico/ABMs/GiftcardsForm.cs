using System;
using System.Data;
using System.Windows.Forms;

namespace EscritorioClasico.ABMs
{
    public partial class GiftcardsForm : Form
    {
        // *-------------------------------------------------------=> SINGLETON
        private GiftcardsForm()
        {
            InitializeComponent();
        }
        private static GiftcardsForm instancia = null;
        public static GiftcardsForm Instancia()
        {
            if (instancia == null) instancia = new GiftcardsForm();
            return instancia;
        }
        private void GiftcardsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
        // *-------------------------------------------------------=> *********

        #region DUMMY DATA
        private void GiftcardsForm_Load(object sender, EventArgs e)
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
            GiftcardsDataGridView.DataSource = null;
            GiftcardsDataGridView.DataSource = datos.Tables[0].DefaultView;
        }
        private void GiftcardsDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0) MessageBox.Show(GiftcardsDataGridView[(e.ColumnIndex + 3), e.RowIndex].Value.ToString() + ": estás a punto de borrar.");
                if (e.ColumnIndex == 1) MessageBox.Show(GiftcardsDataGridView[(e.ColumnIndex + 2), e.RowIndex].Value.ToString() + ": vas a editar...");
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        private void AltaGitfcardButton_Click(object sender, EventArgs e)
        {
            GiftcardForm formulario = GiftcardForm.Instancia();
            DialogResult respuesta = formulario.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                MessageBox.Show("DialogResult: OK");
            }
        }
    }
}
