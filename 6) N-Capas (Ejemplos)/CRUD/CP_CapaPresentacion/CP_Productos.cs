using System;
using System.Windows.Forms;
using CN_CapaNegocio;

namespace CP_CapaPresentacion
{
    public partial class CP_Productos : Form
    {
        public CP_Productos()
        {
            InitializeComponent();
        }

        private void CP_Productos_Load(object sender, EventArgs e)
        {
            CP_MuestraProductos();
        }

        private void CP_MuestraProductos()
        {
            CN_Productos productos = new CN_Productos();
            dgvProductos.DataSource = productos.CN_MuestraProductos();
        }

        private void cmdAgregarProducto_Click(object sender, EventArgs e)
        {
            CN_Productos productos = new CN_Productos();
            try
            {
                productos.CN_InsertaProducto(
                                tboxNombre.Text,
                                tboxDescripcion.Text,
                                tboxMarca.Text,
                                tboxPrecio.Text,
                                tboxStock.Text);
                CP_MuestraProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdEditarProducto_Click(object sender, EventArgs e)
        {
            CN_Productos productos = new CN_Productos();
            try
            {
                productos.CN_EditaProducto(
                                tboxNombre.Text,
                                tboxDescripcion.Text,
                                tboxMarca.Text,
                                tboxPrecio.Text,
                                tboxStock.Text,
                                tboxId.Text);
                CP_MuestraProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmdEliminarProducto_Click(object sender, EventArgs e)
        {
            CN_Productos productos = new CN_Productos();
            try
            {
                productos.CN_EliminaProducto(tboxId.Text);
                CP_MuestraProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
