using Design_Patterns.Models.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design_Patterns.Views.Desktop
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
            VerRegistros(String.Empty);
        }

        private void VerRegistros(string condicion)
        {
            DAOCliente DAO = new DAOCliente();
            dgvClientes.DataSource = DAO.VerRegistros(condicion);
        }


        private void cmdFiltrar_TextChanged(object sender, EventArgs e)
        {
            VerRegistros(tboxFiltrar.Text);
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            VerRegistros(tboxFiltrar.Text);
        }
    }
}
