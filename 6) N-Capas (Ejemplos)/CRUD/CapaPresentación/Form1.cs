using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentación
{
    public partial class Form1 : Form
    {
        CN_Productos cN_Productos = new CN_Productos();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            CP_MuestraProductos();
        }

        private void CP_MuestraProductos()
        {
            dataGridView1.DataSource = cN_Productos.CN_MuestraProductos();
        }
    }
}
