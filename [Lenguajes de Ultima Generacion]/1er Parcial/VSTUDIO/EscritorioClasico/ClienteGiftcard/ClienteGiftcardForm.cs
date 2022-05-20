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
        private void ClienteGiftcardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
        // *-------------------------------------------------------=> *********
    }
}
