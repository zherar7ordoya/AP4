using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Bodega
{
    public partial class EditarProveedorForm : Form
    {
        public EditarProveedorForm() => InitializeComponent();

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ModificarProveedor();
            LimpiarControles(this);
        }

        private void ModificarProveedor()
        {
            int id = int.Parse(txtID.Text);
            InventarioContainer modelo = new InventarioContainer();

            Proveedor dato = (from q in modelo.ProveedorSet where q.ProveedorID == id select q).First();
            dato.ProveedorNombre = txtNombre.Text;
            dato.ProveedorDireccion = txtDireccion.Text;
            dato.ProveedorTelefono = txtTelefono.Text;
            dato.ProveedorEmail = txtEmail.Text;
            modelo.SaveChanges();

            MessageBox.Show("Modificación realizada.");
            this.Close();
        }

        private void LimpiarControles(Control ctrl)
        {
            foreach (var x in ctrl.Controls)
            {
                if (x is TextBox tbox)
                {
                    tbox.Text = string.Empty;
                }
            }
        }

        private void EditarProveedorForm_Load(object sender, EventArgs e) => LlenarForm();

        private void LlenarForm()
        {
            InventarioContainer modelo = new InventarioContainer();
            IQueryable<Proveedor> datos = from q in modelo.ProveedorSet where q.ProveedorID == ListadoForm.IdProveedor select q;
            List<Proveedor> lista = datos.ToList();

            txtID.Text = lista[0].ProveedorID.ToString();
            txtNombre.Text = lista[0].ProveedorNombre.ToString();
            txtDireccion.Text = lista[0].ProveedorDireccion.ToString();
            txtTelefono.Text = lista[0].ProveedorTelefono.ToString();
            txtEmail.Text = lista[0].ProveedorEmail.ToString();
        }
    }
}
