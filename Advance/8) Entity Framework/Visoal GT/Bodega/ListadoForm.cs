using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bodega
{
    public partial class ListadoForm : Form
    {
        public ListadoForm() => InitializeComponent();

        private void ListadoForm_Activated(object sender, EventArgs e) => LlenarGrid();

        private void LlenarGrid()
        {
            dataGridView1.Rows.Clear();

            InventarioContainer modelo = new InventarioContainer();
            IQueryable<Proveedor> datos = from q in modelo.ProveedorSet select q;
            List<Proveedor> lista = datos.ToList();
            dataGridView1.ColumnCount = 5;
            dataGridView1.ColumnHeadersVisible = true;

            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Nombre";
            dataGridView1.Columns[2].Name = "Dirección";
            dataGridView1.Columns[3].Name = "Teléfono";
            dataGridView1.Columns[4].Name = "Email";

            for (int i=0;i<lista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells["ID"].Value = lista[i].ProveedorID;
                dataGridView1.Rows[i].Cells["Nombre"].Value = lista[i].ProveedorNombre;
                dataGridView1.Rows[i].Cells["Dirección"].Value = lista[i].ProveedorDireccion;
                dataGridView1.Rows[i].Cells["Teléfono"].Value = lista[i].ProveedorTelefono;
                dataGridView1.Rows[i].Cells["Email"].Value = lista[i].ProveedorEmail;
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            ProveedorForm x = new ProveedorForm();
            x.MdiParent = this.MdiParent;
            x.Show();
        }

        private void BtnEliminar_Click(object sender, EventArgs e) => EliminarProveedor();

        private void EliminarProveedor()
        {
            int id = int.Parse(dataGridView1.CurrentCell.Value.ToString());
            InventarioContainer modelo = new InventarioContainer();
            Proveedor prov = (Proveedor)(from q in modelo.ProveedorSet where q.ProveedorID == id select q).First();
            modelo.ProveedorSet.Remove(prov);
            modelo.SaveChanges();
            MessageBox.Show("Registro eliminado");
            LlenarGrid();
        }
    }
}
