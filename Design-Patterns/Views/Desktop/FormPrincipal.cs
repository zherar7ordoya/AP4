using System;
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
            //Línea que corresponde a la implementación del Patrón Singleton
            FormClientes formulario = FormClientes.Instanciamiento();

            formulario.MdiParent = this;
            formulario.Show();
            formulario.BringToFront();
        }

        private void itemLibros_Click(object sender, EventArgs e)
        {
            //Línea que corresponde a la implementación del Patrón Singleton
            FormLibros formulario = FormLibros.Instanciamiento();

            formulario.MdiParent = this;
            formulario.Show();
            formulario.BringToFront();
        }
    }
}
