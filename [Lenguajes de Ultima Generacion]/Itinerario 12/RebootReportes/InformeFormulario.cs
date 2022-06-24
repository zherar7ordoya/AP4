using System.Windows.Forms;

namespace RebootReportes
{
    public partial class InformeFormulario : Form
    {
        public InformeFormulario() => InitializeComponent();

        private void InformeFormulario_Load(object sender, System.EventArgs e)
        {
            // TODO: This line of code loads data into the 'i12DataSet.Persona' table. You can move, or remove it, as needed.
            this.PersonaTableAdapter.Fill(this.i12DataSet.Persona);
            this.reportViewer1.RefreshReport();
        }
    }
}
