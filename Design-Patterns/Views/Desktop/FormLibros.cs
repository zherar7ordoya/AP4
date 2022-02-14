using System.Windows.Forms;

namespace Design_Patterns.Views.Desktop
{
    public partial class FormLibros : Form
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
        private FormLibros()
        {
            InitializeComponent();
        }

        //Crear variable estática privada
        private static FormLibros instancia = null;

        //Crear método estático público
        public static FormLibros Instanciamiento()
        {
            if (instancia is null)
            {
                instancia = new FormLibros();
            }
            return instancia;
        }
        // *--------------------=> Finaliza implementación del Patrón Singleton


        //Accessing the form using a static instance instead of creating a new one
        private void FormLibros_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
