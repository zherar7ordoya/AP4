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

namespace Video84
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Capitales> ListaCapitales = new List<Capitales>();
            ListaCapitales.Add(new Capitales { NombreCapital = "Madrid" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Bogotá" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Lima" });
            ListaCapitales.Add(new Capitales { NombreCapital = "DF" });
            ListaCapitales.Add(new Capitales { NombreCapital = "Santiago" });
            Capitales.ItemsSource = ListaCapitales;
        }

        private void TodosLosCB_CheckedChanged(object sender, RoutedEventArgs e)
        {
            bool NuevoValor = (TodosLosCB.IsChecked == true);
            Madrid.IsChecked = NuevoValor;
            Bogotá.IsChecked = NuevoValor;
            Lima.IsChecked = NuevoValor;
            DF.IsChecked = NuevoValor;
            Santiago.IsChecked = NuevoValor;
        }

        private void Capital_CheckedChanged(object sender, RoutedEventArgs e)
        {
            TodosLosCB.IsChecked = null;
            if
            (
                (Madrid.IsChecked == true) &&
                (Bogotá.IsChecked == true) &&
                (Lima.IsChecked == true) &&
                (DF.IsChecked == true) &&
                (Santiago.IsChecked == true)
            ) { TodosLosCB.IsChecked = true; }
            else if
            (
                (Madrid.IsChecked == false) &&
                (Bogotá.IsChecked == false) &&
                (Lima.IsChecked == false) &&
                (DF.IsChecked == false) &&
                (Santiago.IsChecked == false)
            ) { TodosLosCB.IsChecked = false; }
        }
    }

    public class Capitales
    {
        public string NombreCapital { get; set; }
    }
}
