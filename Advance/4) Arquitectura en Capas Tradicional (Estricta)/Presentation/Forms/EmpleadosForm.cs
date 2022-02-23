using System;
using System.Windows.Forms;
using Domain.ValueObjects;
using Domain.Models;

namespace Presentation.Forms
{
    public partial class EmpleadosForm : Form
    {
        private readonly EmpleadosModel empleado = new EmpleadosModel();
        public EmpleadosForm() => InitializeComponent();

        private void EmpleadosForm_Load(object sender, EventArgs e)
        {
            Seleccionar();
            panelGuardar.Enabled = false;
        }

        private void Seleccionar()
        {
            try
            {
                dgvEmpleados.DataSource = empleado.Seleccionar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TboxFiltrar_TextChanged(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = empleado.EncontrarLegajo(tboxFiltrar.Text);
        }

        private void CmdGuardar_Click(object sender, EventArgs e)
        {
            empleado.Legajo = tboxLegajo.Text;
            empleado.Nombre = tboxNombre.Text;
            empleado.Email = tboxEmail.Text;
            empleado.Nacimiento = dtpNacimiento.Value;

            bool valido = new Helps.DataValidation(empleado).Validar();
            if (valido)
            {
                string resultado = empleado.Guardar();
                MessageBox.Show(resultado);
                Seleccionar();
                Restablecer();
            }
        }

        private void Restablecer()
        {
            panelGuardar.Enabled = false;
            tboxLegajo.Clear();
            tboxNombre.Clear();
            tboxEmail.Clear();
        }

        private void CmdAgregar_Click(object sender, EventArgs e)
        {
            panelGuardar.Enabled = true;
            empleado.Estado = EntityState.Agregado;
        }

        private void CmdModificar_Click(object sender, EventArgs e)
        {
            panelGuardar.Enabled = true;
            empleado.Estado = EntityState.Modificado;

            empleado.Id = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value);
            
            tboxLegajo.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[1].Value);
            tboxNombre.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[2].Value);
            tboxEmail.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[3].Value);
            dtpNacimiento.Value = Convert.ToDateTime(dgvEmpleados.CurrentRow.Cells[4].Value);
        }

        private void CmdEliminar_Click(object sender, EventArgs e)
        {
            empleado.Estado = EntityState.Eliminado;
            empleado.Id = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value);
            string resultado = empleado.Guardar();
            MessageBox.Show(resultado);
            Seleccionar();
        }
    }
}
