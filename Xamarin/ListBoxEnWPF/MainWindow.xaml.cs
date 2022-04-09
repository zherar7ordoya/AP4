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

namespace ListBoxEnWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Poblaciones> poblaciones = new List<Poblaciones>();

            poblaciones.Add(new Poblaciones
            {
                Poblacion1 = "Madrid",
                Poblacion2 = "Barcelona",
                Temperatura1 = 15,
                Temperatura2 = 17,
                Diferencia = 3
            });
            poblaciones.Add(new Poblaciones
            {
                Poblacion1 = "Valencia",
                Poblacion2 = "Alicane",
                Temperatura1 = 19,
                Temperatura2 = 20,
                Diferencia = 6
            });
            poblaciones.Add(new Poblaciones
            {
                Poblacion1 = "Málaga",
                Poblacion2 = "Bilbao",
                Temperatura1 = 20,
                Temperatura2 = 7,
                Diferencia = -3
            });
            poblaciones.Add(new Poblaciones
            {
                Poblacion1 = "Sevilla",
                Poblacion2 = "Coruña",
                Temperatura1 = 22,
                Temperatura2 = 8,
                Diferencia = -6
            });

            ListaPoblaciones.ItemsSource = poblaciones;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ListaPoblaciones.SelectedItem is null)
            {
                MessageBox.Show("Nada seleccionado", "Ups...", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                MessageBox.Show
                    (
                        (ListaPoblaciones.SelectedItem as Poblaciones).Poblacion1 + "\t" +
                        (ListaPoblaciones.SelectedItem as Poblaciones).Temperatura1 + "Cº\n" +
                        (ListaPoblaciones.SelectedItem as Poblaciones).Poblacion2 + "\t" +
                        (ListaPoblaciones.SelectedItem as Poblaciones).Temperatura2 + "Cº"
                    );
            }
        }

        private void RowDefinition_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Button_Click(this, (RoutedEventArgs)EventArgs.Empty);
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Button_Click(this, null);
        }
    }
}
