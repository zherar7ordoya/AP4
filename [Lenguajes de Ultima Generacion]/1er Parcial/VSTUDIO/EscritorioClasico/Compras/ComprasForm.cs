using System;
using System.Data;
using System.Windows.Forms;

namespace EscritorioClasico.Compras
{
    public partial class ComprasForm : Form
    {
        // *-------------------------------------------------------=> SINGLETON
        private ComprasForm() => InitializeComponent();
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

        // *----------------------------------------------------=> INAUGURACIÓN

        private void ComprasForm_Load(object sender, EventArgs e) => InauguraForm();

        readonly BLL.Cliente bllCliente = new BLL.Cliente();

        private void InauguraForm()
        {
            this.ComprasDataGridView.DataSource = null;
            this.ComprasDataGridView.Rows.Clear();
            this.ComprasDataGridView.DataSource = bllCliente.Listar();
        }



        private void AltaCompraButton_Click(object sender, EventArgs e)
        {
            // Instancio el Form ABM y le paso los datos a editar.
            CompraForm formulario = new CompraForm();

            formulario.CodigoTextBox.Text = belCliente.Codigo.ToString();
            formulario.NombreTextBox.Text = belCliente.Nombre.ToString();
            formulario.ApellidoTextBox.Text = belCliente.Apellido.ToString();
            formulario.DNITextBox.Text = belCliente.DNI.ToString();
            formulario.FechaVencimientoDateTimePicker.Value = belCliente.FechaNacimiento;

            // Si la respuesta es OK, actualizo la grilla.
            DialogResult respuesta = formulario.ShowDialog();
            if (respuesta == DialogResult.OK) CargaInicial();





            CompraForm formulario = CompraForm.Instancia();
            DialogResult respuesta = formulario.ShowDialog();
            if (respuesta == DialogResult.OK) MessageBox.Show("DialogResult: OK");
        }

    }
}
