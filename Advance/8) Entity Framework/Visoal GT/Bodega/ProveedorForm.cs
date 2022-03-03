using System;
using System.Windows.Forms;

namespace Bodega
{
    public partial class ProveedorForm : Form
    {
        public ProveedorForm() => InitializeComponent();

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            AgregarProveedor();
            LimpiarControles(this);
        }

        private void AgregarProveedor()
        {
            InventarioContainer modelo = new InventarioContainer();
            Proveedor prov = new Proveedor()
            {
                ProveedorID = Convert.ToInt32(txtID.Text),
                ProveedorNombre = txtNombre.Text,
                ProveedorDireccion = txtDireccion.Text,
                ProveedorTelefono = txtTelefono.Text,
                ProveedorEmail = txtEmail.Text
            };
            modelo.ProveedorSet.Add(prov);
            modelo.SaveChanges();
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


    }
}
