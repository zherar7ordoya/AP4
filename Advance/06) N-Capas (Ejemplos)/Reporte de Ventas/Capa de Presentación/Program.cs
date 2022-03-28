using System;
using System.Windows.Forms;

namespace Capa_de_Presentación
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ReporteDeVentas());
        }
    }
}
