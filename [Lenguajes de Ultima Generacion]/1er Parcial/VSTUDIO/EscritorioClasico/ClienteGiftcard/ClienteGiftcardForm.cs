using System.Collections.Generic;
using System.Windows.Forms;

namespace EscritorioClasico.ClienteGiftcard
{
    public partial class ClienteGiftcardForm : Form
    {
        BEL.Cliente cliente;
        BLL.Cliente clientes;
        BLL.TarjetaInternacional internacional;
        BLL.TarjetaNacional nacional;

        // *-------------------------------------------------------=> SINGLETON
        private ClienteGiftcardForm()
        {
            InitializeComponent();
            cliente = new BEL.Cliente();
            clientes = new BLL.Cliente();
            internacional = new BLL.TarjetaInternacional();
            nacional = new BLL.TarjetaNacional();
        }

        private static ClienteGiftcardForm instancia = null;
        public static ClienteGiftcardForm Instancia()
        {
            if (instancia == null) instancia = new ClienteGiftcardForm();
            return instancia;
        }

        private void ClienteGiftcardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
        // *-------------------------------------------------------=> *********


        private void ClienteGiftcardForm_Load(object sender, System.EventArgs e)
        {
            this.ClientesDataGridView.DataSource = null;
            this.ClientesDataGridView.Rows.Clear();
            this.ClientesDataGridView.DataSource = clientes.Listar();

            this.InternacionalesDisponiblesDataGridView.DataSource = null;
            this.InternacionalesDisponiblesDataGridView.Rows.Clear();
            this.InternacionalesDisponiblesDataGridView.DataSource = internacional.ListarDisponibles();

            this.NacionalesDisponiblesDataGridView.DataSource = null;
            this.NacionalesDisponiblesDataGridView.Rows.Clear();
            this.NacionalesDisponiblesDataGridView.DataSource = nacional.ListarDisponibles();
        }

        private void ClientesDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            cliente = (BEL.Cliente)ClientesDataGridView.CurrentRow.DataBoundItem;
            BEL.Cliente objeto = clientes.Detallar(cliente);
            //CargarInternacionales(objeto);
            //CargarNacionales(objeto);
            GiftcardAsignada(objeto);
        }

        void CargarInternacionales(BEL.Cliente cliente)
        {
            this.InternacionalesDisponiblesDataGridView.DataSource = null;
            this.InternacionalesDisponiblesDataGridView.Rows.Clear();
            //this.InternacionalesDisponiblesDataGridView.DataSource = ListarInternacionales(cliente);
            this.InternacionalesDisponiblesDataGridView.DataSource = internacional.ListarDisponibles();
        }




        public List<BEL.TarjetaInternacional> ListarInternacionales(BEL.Cliente objeto)
        {
            List<BEL.TarjetaInternacional> ListaTarjetas = new List<BEL.TarjetaInternacional>();
            BEL.Cliente cliente = clientes.Detallar(objeto);

            if (cliente.Tarjeta != null)
            {
                foreach (BEL.Tarjeta tarjeta in cliente.Tarjeta)
                {
                    if (tarjeta is BEL.TarjetaInternacional) ListaTarjetas.Add((BEL.TarjetaInternacional)tarjeta);
                }
            }
            return ListaTarjetas;
        }

        //TODO: En BD, cambiar Vencimiento a FechaVencimiento
        //TODO: En BD, cambiar Cliente_Tarjeta a ClientesTarjetas
        //TODO: En BD, cambiar Descuento a Descuentos (¿?) DEFINIR

        public void GiftcardAsignada(BEL.Cliente objeto)
        {
            List<BEL.TarjetaInternacional> ListaInternacionales = new List<BEL.TarjetaInternacional>();
            List<BEL.TarjetaNacional> ListaNacionales = new List<BEL.TarjetaNacional>();
            BEL.Cliente cliente = clientes.Detallar(objeto);

            if (cliente.Tarjeta != null)
            {
                foreach (BEL.Tarjeta tarjeta in cliente.Tarjeta)
                {
                    this.CodigoTextBox.Text = tarjeta.Codigo.ToString();
                    if (tarjeta is BEL.TarjetaInternacional) this.TipoTextBox.Text = "Internacional";
                    this.NumeroTextBox.Text = tarjeta.Numero.ToString();
                    this.FechaVencimientoTextBox.Text = tarjeta.Vencimiento.ToString();
                    this.SaldoTextBox.Text = tarjeta.Saldo.ToString();
                    this.DescuentosTextBox.Text = tarjeta.Descuento.ToString();
                    this.RubroTextBox.Text = tarjeta.Rubro.ToString();
                    this.EstadoTextBox.Text = tarjeta.Estado.ToString();
                    this.PaisTextBox.Text=tarjeta.Pais.ToString();
                    //if (tarjeta is BEL.TarjetaNacional) this.ProvinciaTextBox.Text = tarjeta.Pr
                }
            }

        }


        void CargarNacionales(BEL.Cliente cliente)
        {
            this.NacionalesDisponiblesDataGridView.DataSource = null;
            this.NacionalesDisponiblesDataGridView.Rows.Clear();
            //this.NacionalesDisponiblesDataGridView.DataSource = ListarNacionales(cliente);
            this.NacionalesDisponiblesDataGridView.DataSource = nacional.ListarDisponibles();
        }


        public List<BEL.TarjetaNacional> ListarNacionales(BEL.Cliente objeto)
        {
            List<BEL.TarjetaNacional> ListaTarjetas = new List<BEL.TarjetaNacional>();
            BEL.Cliente cliente = clientes.Detallar(objeto);

            if (cliente.Tarjeta != null)
            {
                foreach (BEL.Tarjeta tarjeta in cliente.Tarjeta)
                {
                    if (tarjeta is BEL.TarjetaNacional) ListaTarjetas.Add((BEL.TarjetaNacional)tarjeta);
                }
            }
            return ListaTarjetas;
        }

    }
}
