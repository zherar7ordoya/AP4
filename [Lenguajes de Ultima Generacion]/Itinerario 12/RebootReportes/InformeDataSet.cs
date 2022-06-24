using System.Windows.Forms;

namespace RebootReportes
{
    public partial class InformeDataSet : Form
    {
        public InformeDataSet() => InitializeComponent();

        private void InformeFormulario_Load(object sender, System.EventArgs e)
        {
            this.PersonaTableAdapter.Fill(this.i12DataSet.Persona);
            this.reportViewer1.RefreshReport();
        }
    }
}
