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
    public partial class GiftcardsForm : Form
    {
        // *-------------------------------------------------------=> SINGLETON
        private GiftcardsForm()
        {
            InitializeComponent();
        }
        private static GiftcardsForm instancia = null;
        public static GiftcardsForm Instancia()
        {
            if (instancia == null) instancia = new GiftcardsForm();
            return instancia;
        }
        // *-------------------------------------------------------=> *********
    }
}
