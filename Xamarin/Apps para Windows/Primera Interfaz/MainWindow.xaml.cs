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

namespace Primera_Interfaz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid grid = new Grid();
            this.Content = grid;
            Button button = new Button();

            WrapPanel panel = new WrapPanel();

            TextBlock txt1 = new TextBlock();
            txt1.Text = "Click";
            panel.Children.Add(txt1);

            TextBlock txt2 = new TextBlock();
            txt2.Text = "Enviar";
            panel.Children.Add(txt2);

            TextBlock txt3 = new TextBlock();
            txt3.Text = "Algo";
            panel.Children.Add(txt3);

            button.Content = panel;
            grid.Children.Add(button);
        }
    }
}
