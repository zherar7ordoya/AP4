using System.Windows;

namespace UIInsumosOficina
{
    /// <summary>
    /// Interaction logic for OrderItemDialog.xaml
    /// </summary>
    public partial class ItemDialogo : Window
    {
        public ItemDialogo()
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