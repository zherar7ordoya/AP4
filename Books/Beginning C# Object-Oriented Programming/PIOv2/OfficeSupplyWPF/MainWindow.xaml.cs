using System.Windows;
using System.Data;
using OfficeSupplyBLL;

namespace UIInsumosOficina
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DataSet _catalogo;
        BLLEmpleado _empleado;
        BLLOrden _orden;

        public MainWindow() => InitializeComponent();

        private void Despegue(object sender, RoutedEventArgs e)
        {
            BLLCatalogo catalogo = new BLLCatalogo();
            _catalogo = catalogo.ObtenerInfoProducto();
            DataContext = _catalogo.Tables["Categorias"];
            _orden = new BLLOrden();
            _empleado = new BLLEmpleado();
            OrdenesListView.ItemsSource = _orden.ItemsList;
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {

            LoginDialogo ldialogo = new LoginDialogo();
            ldialogo.Owner = this;
            ldialogo.ShowDialog();

            if (ldialogo.DialogResult == true)
            {
                _empleado.Usuario = ldialogo.NombreTextBox.Text;
                _empleado.Contraseña = ldialogo.ContraseñaTextBox.Password;
                if (_empleado.Login() == true)
                {
                    EstadoTextBlock.Text = "Está logueado como empleado código " +
                      _empleado.EmployeeID.ToString();
                }
                else
                {
                    MessageBox.Show("Necesita identificarse. Intente otra vez.");
                }
            }
        }

        private void Salir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {

            ItemDialogo orderItemDialog = new ItemDialogo();

            DataRowView selectedRow;
            selectedRow = (DataRowView)ProductsDataGrid.SelectedItems[0];
            orderItemDialog.productIdTextBox.Text = selectedRow.Row.ItemArray[0].ToString();
            orderItemDialog.unitPriceTextBox.Text = selectedRow.Row.ItemArray[4].ToString();
            orderItemDialog.Owner = this;
            orderItemDialog.ShowDialog();
            if (orderItemDialog.DialogResult == true)
            {
                string productId = orderItemDialog.productIdTextBox.Text;
                double unitPrice = double.Parse(orderItemDialog.unitPriceTextBox.Text);
                int quantity = int.Parse(orderItemDialog.quantityTextBox.Text);
                _orden.AddItem(new BLLItem(productId, unitPrice, quantity));
            }
        }

        private void Quitar_Click(object sender, RoutedEventArgs e)
        {
            if (OrdenesListView.SelectedItem != null)
            {
                var selectedOrderItem = OrdenesListView.SelectedItem as BLLItem;
                _orden.RemoveItem(selectedOrderItem.ProdID);
            }
        }

        private void RealizarPedido_Click(object sender, RoutedEventArgs e)
        {
            if (_empleado.LoggedIn == true)
            {
                //place order
                int orderId;
                orderId = _orden.PlaceOrder(_empleado.EmployeeID);
                MessageBox.Show("Pedido efectuado con código de orden " +
                     orderId.ToString());
            }
            else
            {
                MessageBox.Show("Debe estar logueado para realizar un pedido.");
            }
        }
    }
}