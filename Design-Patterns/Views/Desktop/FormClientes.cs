using Design_Patterns.Models.DAO;
using System;
using System.Windows.Forms;

namespace Design_Patterns.Views.Desktop
{
    public partial class FormClientes : Form
    {
        /**
         * PATRÓN SINGLETON DE DISEÑO
         * Se usará aquí para que evite abrir varios veces el mismo formulario.
         * 
         * NOTA: Observar cómo se crea la instancia en FormPrincipal
         * 
         * Procedimiento:
         */

        //Cambiar el public del constructor a private
        private FormClientes()
        {
            InitializeComponent();
        }

        //Crear variable estática privada
        private static FormClientes instancia = null;

        //Crear método estático público
        public static FormClientes Instanciamiento()
        {
            if (instancia is null)
            {
                instancia = new FormClientes();
            }
            return instancia;
        }
        // *--------------------=> Finaliza implementación del Patrón Singleton


        /**
         * Yo no recomendaria que allí (en el constructor, junto con el
         * InitializeComponent) definas código que accede a los controles. El
         * acceso a los controles se define en el Load, lo cual te asegurará
         * que el Layout del Form está iniciado y es seguro acceder a sus
         * componentes (TextBox, ComboBox, Button, etcétera).
         * Hay acciones que si puedes hacerlas alli (en el constructor) como
         * pasar algún dato al Form por medio del constructor (?) o crear
         * alguna instancia de clase, etc.
         */
        private void FormClientes_Load(object sender, EventArgs e)
        {
            VerRegistros(String.Empty);
        }

        private void VerRegistros(string condicion)
        {
            DAOCliente DAO = new DAOCliente();
            dgvClientes.DataSource = DAO.RecuperarRegistros(condicion);
        }

        private void cmdFiltrar_TextChanged(object sender, EventArgs e)
        {
            VerRegistros(tboxFiltrar.Text);
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            VerRegistros(tboxFiltrar.Text);
        }


        //Accessing the form using a static instance instead of creating a new one
        private void FormClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
