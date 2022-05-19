using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscritorioClasico.Compras
{
    public partial class ComprasForm : Form
    {
        // *-------------------------------------------------------=> SINGLETON
        private ComprasForm()
        {
            InitializeComponent();
        }
        private static ComprasForm instancia = null;
        public static ComprasForm Instancia()
        {
            if (instancia == null) instancia = new ComprasForm();
            return instancia;
        }
        // *-------------------------------------------------------=> *********    }
    }
}
