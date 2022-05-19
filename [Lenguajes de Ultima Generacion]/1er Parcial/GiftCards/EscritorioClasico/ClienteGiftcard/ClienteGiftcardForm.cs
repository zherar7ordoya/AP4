using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscritorioClasico.ClienteGiftcard
{
    public partial class ClienteGiftcardForm : Form
    {
        // *-------------------------------------------------------=> SINGLETON
        private ClienteGiftcardForm()
        {
            InitializeComponent();
        }
        private static ClienteGiftcardForm instancia = null;
        public static ClienteGiftcardForm Instancia()
        {
            if (instancia == null) instancia = new ClienteGiftcardForm();
            return instancia;
        }
        // *-------------------------------------------------------=> *********    }
    }
}
