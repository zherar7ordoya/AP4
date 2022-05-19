using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscritorioClasico.ABMs
{
    public partial class GiftcardForm : Form
    {
        // *-------------------------------------------------------=> SINGLETON
        private GiftcardForm()
        {
            InitializeComponent();
        }
        private static GiftcardForm instancia = null;
        public static GiftcardForm Instancia()
        {
            if (instancia == null) instancia = new GiftcardForm();
            return instancia;
        }
        // *-------------------------------------------------------=> *********
    }
}
