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
    public partial class XML_Form : Form
    {
        public XML_Form()
        {
            InitializeComponent();
        }

        private void MostrarButton_Click(object sender, EventArgs e)
        {
            var desde = DesdeDTP.Value;
            var hasta = HastaDTP.Value;
            //dataGridView1.DataSource = DAL.Conexion.ConsultaParaReporte(desde, hasta);
        }
    }
}
