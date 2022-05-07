using System.Windows;

namespace UIInsumosOficina
{
    /// <summary>
    /// Interaction logic for LoginDialog.xaml
    /// </summary>
    public partial class LoginDialogo : Window
    {
        public LoginDialogo()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
        private void Cancelar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
