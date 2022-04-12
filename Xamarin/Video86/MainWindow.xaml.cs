using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Video86
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioRojo_Click(object sender, RoutedEventArgs e)
        {
            Apagar();
            eRojo.Visibility = Visibility.Visible;
        }
        private void RadioAmarillo_Click(object sender, RoutedEventArgs e)
        {
            Apagar();
            eAmarillo.Visibility = Visibility.Visible;
        }
        private void RadioVerde_Click(object sender, RoutedEventArgs e)
        {
            Apagar();
            eVerde.Visibility = Visibility.Visible;
        }
        private void Apagar()
        {
            eRojo.Visibility = Visibility.Hidden;
            eAmarillo.Visibility = Visibility.Hidden;
            eVerde.Visibility = Visibility.Hidden;
        }
    }
}
