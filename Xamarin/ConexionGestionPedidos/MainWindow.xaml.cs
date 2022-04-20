using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Data.SqlClient;
using System.Data;

namespace ConexionGestionPedidos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection miConexionSql;

        public MainWindow()
        {
            InitializeComponent();
            string miConexion = ConfigurationManager
                .ConnectionStrings["ConexionGestionPedidos.Properties.Settings.GestionPedidosConnectionString"]
                .ConnectionString;
            miConexionSql = new SqlConnection(miConexion);
            MuestraClientes();
        }

        private void MuestraClientes()
        {
            string consulta = "SELECT * FROM Cliente";
            SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);
            using (miAdaptadorSql)
            {
                DataTable clientesTabla = new DataTable();
                miAdaptadorSql.Fill(clientesTabla);
                ListaClientes.DisplayMemberPath = "Nombre";
                ListaClientes.SelectedValuePath = "Id";
                ListaClientes.ItemsSource = clientesTabla.DefaultView;
            }
        }
    }
}
