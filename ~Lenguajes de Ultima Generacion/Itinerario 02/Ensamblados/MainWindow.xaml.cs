using System.Windows;

namespace Ensamblados
{
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();
        private void Button_Click(object sender, RoutedEventArgs e) => MessageBox.Show("No he venido, amigos, a robar vuestros corazones.");
    }
}
