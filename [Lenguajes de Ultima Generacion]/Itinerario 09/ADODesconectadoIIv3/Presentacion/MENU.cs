using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Presentacion
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        
        private void crearDSEnMemoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            FrmCrearDS oFrmCrearDs = new FrmCrearDS();
            oFrmCrearDs.MdiParent = this;
            oFrmCrearDs.Show();
        }

        private void aBMSimpleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ABMSimpleDesconectado oFrmABMSimple = new ABMSimpleDesconectado();
            oFrmABMSimple.MdiParent = this;
            oFrmABMSimple.Show();
        }

        private void aBMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ABMSimple_TextBox oFrmABMI = new ABMSimple_TextBox();
            oFrmABMI.MdiParent = this;
            oFrmABMI.Show();
        }

        private void aBMStateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMDesconectaado oFrmABM = new ABMDesconectaado();
            oFrmABM.MdiParent = this;
            oFrmABM.Show();
        }

       

        private void MENU_Load(object sender, EventArgs e)
        {
     
        }

        private void filtrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filtros oFfil = new Filtros();
            oFfil.MdiParent = this;
            oFfil.Show();
        }

        private void filtrosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Filtros oFil = new Filtros();
            oFil.MdiParent = this;
            oFil.Show();
        }
    }
}
