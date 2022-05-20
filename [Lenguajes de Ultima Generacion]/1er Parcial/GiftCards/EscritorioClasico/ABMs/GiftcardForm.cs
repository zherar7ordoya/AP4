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
