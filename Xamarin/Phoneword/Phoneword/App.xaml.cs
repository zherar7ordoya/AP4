using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Phoneword
{
    // La clase App es de la que los proyectos principales crean una instancia
    // y la que cargan.
    public partial class App : Application
    {
        // El constructor de la clase App establece su propia propiedad
        // MainPage. Esta propiedad controlará la primera pantalla que ve el
        // usuario.
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
