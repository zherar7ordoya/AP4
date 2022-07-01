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
    public partial class MultipleDocumentInterface : Form
    {
        public MultipleDocumentInterface() => InitializeComponent();
        private void Archivo_SalirItem_Click(object sender, EventArgs e) => Application.Exit();

        private void ABM_CategoriasItem_Click(object sender, EventArgs e)
        {
            Categoria formulario = new Categoria
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void ABM_DepartamentosItem_Click(object sender, EventArgs e)
        {
            Departamento formulario = new Departamento
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void ABM_EmpleadosItem_Click(object sender, EventArgs e)
        {
            Empleado formulario = new Empleado
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void ABM_ItemsItem_Click(object sender, EventArgs e)
        {
            Item formulario = new Item
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void ABM_OrdenesItem_Click(object sender, EventArgs e)
        {
            Orden formulario = new Orden
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void ABM_ProveedoresItem_Click(object sender, EventArgs e)
        {
            Proveedor formulario = new Proveedor
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void ABM_RolesItem_Click(object sender, EventArgs e)
        {
            Rol formulario = new Rol
            {
                MdiParent = this
            };
            formulario.Show();
        }

        private void Reportes_OrdenesItem_Click(object sender, EventArgs e)
        {
            Ordenes_Items formulario = new Ordenes_Items
            {
                MdiParent = this
            };
            formulario.Show();
        }
    }
}
