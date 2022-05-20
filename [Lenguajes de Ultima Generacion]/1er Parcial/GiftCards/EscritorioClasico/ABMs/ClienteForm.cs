using System.Windows.Forms;

namespace EscritorioClasico.ABMs
{
    public partial class ClienteForm : Form
    {
        // *-------------------------------------------------------=> SINGLETON
        private ClienteForm()
        {
            InitializeComponent();
        }
        private static ClienteForm instancia = null;
        public static ClienteForm Instancia()
        {
            if (instancia == null) instancia = new ClienteForm();
            return instancia;
        }
        // *-------------------------------------------------------=> *********
    }
}
