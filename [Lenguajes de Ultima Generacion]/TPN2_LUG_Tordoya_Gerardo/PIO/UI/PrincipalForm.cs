using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm() => InitializeComponent();

        private void MultipleDocumentInterface_Load(object sender, EventArgs e)
        {
            LoginForm formulario = new LoginForm()
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void Archivo_SalirItem_Click(object sender, EventArgs e) => Application.Exit();

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        private void ABM_CategoriasItem_Click(object sender, EventArgs e)
        {
            CategoriaForm formulario = new CategoriaForm
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void ABM_DepartamentosItem_Click(object sender, EventArgs e)
        {
            DepartamentoForm formulario = new DepartamentoForm
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void ABM_EmpleadosItem_Click(object sender, EventArgs e)
        {
            EmpleadoForm formulario = new EmpleadoForm
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void ABM_ItemsItem_Click(object sender, EventArgs e)
        {
            ItemForm formulario = new ItemForm
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void ABM_OrdenesItem_Click(object sender, EventArgs e)
        {
            OrdenForm formulario = new OrdenForm
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void ABM_ProveedoresItem_Click(object sender, EventArgs e)
        {
            ProveedorForm formulario = new ProveedorForm
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void ABM_RolesItem_Click(object sender, EventArgs e)
        {
            RolForm formulario = new RolForm
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void Reportes_OrdenesItem_Click(object sender, EventArgs e)
        {
            Ordenes_ItemsForm formulario = new Ordenes_ItemsForm
            {
                MdiParent = this
            };
            formulario.Show();
        }
    }
}
