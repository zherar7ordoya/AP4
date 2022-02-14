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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void itemClientes_Click(object sender, EventArgs e)
        {
            FormClientes formulario = new FormClientes();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void itemLibros_Click(object sender, EventArgs e)
        {
            FormLibros formulario = new FormLibros();
            formulario.MdiParent = this;
            formulario.Show();
        }
    }
}
