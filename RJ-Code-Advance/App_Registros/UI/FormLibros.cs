using System.Windows.Forms;

namespace App_Registros.UI
{
    public partial class FormLibros : Form
    {
        // PATRÓN SINGLETON DE DISEÑO
        // Evita abrir varios veces el mismo formulario.

        /** PATRÓN SINGLETON
         *  -1er requisito: cambiar public FormClientes() a PRIVATE
         *  -Crear variable estática privada
         *  -Crear método estático público
         *  -Observar cómo se crea la instancia en FormPrincipal
         */
        private FormLibros()
        {
            InitializeComponent();
        }
        private static FormLibros Instancia = null;
        public static FormLibros ObtenerInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new FormLibros();
            }
            return Instancia;
        }
    }
}
