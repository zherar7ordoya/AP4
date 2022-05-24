using System;
using System.Data;
using System.Windows.Forms;

namespace EscritorioClasico.ABMs
{
    public partial class ClientesForm : Form
    {
        //APP-1
        BLL.Cliente lgcCliente;
        BEL.Cliente belCliente;

        // *-------------------------------------------------------=> SINGLETON
        private static ClientesForm instancia = null;

        private ClientesForm()
        {
            InitializeComponent();

            //APP-2
            lgcCliente = new BLL.Cliente(); 
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
            CargaInicial();
        }

        private void CargaInicial()
        {
            this.ClientesDataGridView.DataSource = null;
            this.ClientesDataGridView.Rows.Clear();
            this.ClientesDataGridView.DataSource = lgcCliente.Listar();
        }

        private void ClientesDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                belCliente = (BEL.Cliente)this.ClientesDataGridView.CurrentRow.DataBoundItem;

                // ELIMINACIÓN
                if (e.ColumnIndex == 0)
                {
                    DialogResult respuesta;
                    respuesta = MessageBox.Show("¿Confirma eliminación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        if (lgcCliente.Eliminar(belCliente) == false) MessageBox.Show("Registro asociado", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        else { CargaInicial(); }
                    }
                }
                
                //  EDICIÓN
                if (e.ColumnIndex == 1)
                {
                    //instancio el form ABM de materia y le paso los para editar
                    ClienteForm formulario = new ClienteForm();

                    formulario.CodigoTextBox.Text = belCliente.Codigo.ToString();
                    formulario.NombreTextBox.Text = belCliente.Nombre.ToString();
                    formulario.ApellidoTextBox.Text = belCliente.Apellido.ToString();
                    formulario.DNITextBox.Text = belCliente.DNI.ToString();
                    formulario.FechaVencimientoDateTimePicker.Value = belCliente.FechaNacimiento;

                    //si la respuesta es OK, actualizo la grilla
                    DialogResult respuesta = formulario.ShowDialog();
                    if (respuesta == DialogResult.OK) CargaInicial();
                }
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
