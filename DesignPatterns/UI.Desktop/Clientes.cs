using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesignPatterns.DAO;

namespace DesignPatterns.UI.Desktop
{
    public partial class FormularioClientes : Form
    {
        public FormularioClientes()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormularioClientes_Load(object sender, EventArgs e)
        {
            VerRegistros(String.Empty);
        }

        private void VerRegistros(string condicion)
        {
            Cliente DAO = new();
            dgvClientes.DataSource = DAO.VerRegistros(condicion);
        }

        private void tboxFiltrar_TextChanged(object sender, EventArgs e)
        {
            VerRegistros(tboxFiltrar.Text);
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            VerRegistros(tboxFiltrar.Text);
        }
    }
}
