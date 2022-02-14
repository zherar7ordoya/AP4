using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatterns.UI.Desktop
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void ItemClientes_Click(object sender, EventArgs e)
        {
            FormularioClientes formulario = new();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void ItemLibros_Click(object sender, EventArgs e)
        {
            FormularioLibros formulario = new();
            formulario.MdiParent = this;
            formulario.Show();
        }
    }
}
