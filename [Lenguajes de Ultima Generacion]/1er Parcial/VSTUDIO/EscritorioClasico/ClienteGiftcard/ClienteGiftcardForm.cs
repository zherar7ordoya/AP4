using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EscritorioClasico.ClienteGiftcard
{
    public partial class ClienteGiftcardForm : Form
    {
        BEL.Cliente belCliente=new BEL.Cliente();
        BLL.Cliente bllCliente=new BLL.Cliente();

        BEL.TarjetaInternacional belGiftcardInternacional = new BEL.TarjetaInternacional();
        BLL.TarjetaInternacional bllGiftcardInternacional=new BLL.TarjetaInternacional();

        BEL.TarjetaNacional belGiftcardNacional = new BEL.TarjetaNacional();
        BLL.TarjetaNacional bllGiftcardNacional=new BLL.TarjetaNacional();

        // *-------------------------------------------------------=> SINGLETON
        private ClienteGiftcardForm() => InitializeComponent();
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

        private void ClienteGiftcardForm_Load(object sender, System.EventArgs e) => InaugurarForm();

        private void InaugurarForm()
        {
            this.ClientesDataGridView.DataSource = null;
            this.ClientesDataGridView.Rows.Clear();
            this.ClientesDataGridView.DataSource = bllCliente.Listar();

            this.InternacionalesDisponiblesDataGridView.DataSource = null;
            this.InternacionalesDisponiblesDataGridView.Rows.Clear();
            this.InternacionalesDisponiblesDataGridView.DataSource = bllGiftcardInternacional.ListarDisponibles();

            this.NacionalesDisponiblesDataGridView.DataSource = null;
            this.NacionalesDisponiblesDataGridView.Rows.Clear();
            this.NacionalesDisponiblesDataGridView.DataSource = bllGiftcardNacional.ListarDisponibles();

            LimpiarTextBoxes();
        }

        // *---------------------------------------------------------------=> *

        private void ClientesDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            belCliente = (BEL.Cliente)ClientesDataGridView.CurrentRow.DataBoundItem;
            BEL.Cliente objeto = bllCliente.Detallar(belCliente);
            GiftcardAsignada(objeto);
        }


        public void GiftcardAsignada(BEL.Cliente objeto)
        {
            

            BEL.Cliente cliente = bllCliente.Detallar(objeto);

            if (cliente.Tarjeta == null)
            {
                LimpiarTextBoxes();
            }
            else
            {
                if (cliente.Tarjeta[0] is BEL.TarjetaInternacional)
                {
                    foreach (BEL.TarjetaInternacional tarjeta in cliente.Tarjeta)
                    {
                        this.TipoTextBox.Text = "Internacional";
                        this.ProvinciaTextBox.Text = "(Sin asignar)";
                    }
                }
                if (cliente.Tarjeta[0] is BEL.TarjetaNacional)
                {
                    foreach (BEL.TarjetaNacional tarjeta in cliente.Tarjeta)
                    {
                        this.TipoTextBox.Text = "Nacional";
                        this.ProvinciaTextBox.Text = tarjeta.Provincia.ToString();
                    }
                }
                this.CodigoTextBox.Text = cliente.Tarjeta[0].Codigo.ToString();
                this.NumeroTextBox.Text = cliente.Tarjeta[0].Numero.ToString();
                this.FechaVencimientoTextBox.Text = cliente.Tarjeta[0].Vencimiento.ToString();
                this.SaldoTextBox.Text = cliente.Tarjeta[0].Saldo.ToString();
                this.DescuentosTextBox.Text = cliente.Tarjeta[0].Descuento.ToString();
                this.RubroTextBox.Text = cliente.Tarjeta[0].Rubro.ToString();
                this.EstadoTextBox.Text = cliente.Tarjeta[0].Estado.ToString();
                this.PaisTextBox.Text = cliente.Tarjeta[0].Pais.ToString();
            }
        }


        private void LimpiarTextBoxes()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox box) box.Text = string.Empty;
                if (ctrl is GroupBox)
                {
                    foreach (Control txtbox in ctrl.Controls)
                    {
                        if (txtbox is TextBox) txtbox.Text = string.Empty;
                    }
                }
            }
        }

        // *---------------------------------------------------------------=> *

        public List<BEL.TarjetaInternacional> ListarInternacionales(BEL.Cliente objeto)
        {
            List<BEL.TarjetaInternacional> ListaTarjetas = new List<BEL.TarjetaInternacional>();
            BEL.Cliente cliente = bllCliente.Detallar(objeto);

            if (cliente.Tarjeta != null)
            {
                foreach (BEL.Tarjeta tarjeta in cliente.Tarjeta)
                {
                    if (tarjeta is BEL.TarjetaInternacional) ListaTarjetas.Add((BEL.TarjetaInternacional)tarjeta);
                }
            }
            return ListaTarjetas;
        }
        

        public List<BEL.TarjetaNacional> ListarNacionales(BEL.Cliente objeto)
        {
            List<BEL.TarjetaNacional> ListaTarjetas = new List<BEL.TarjetaNacional>();
            BEL.Cliente cliente = bllCliente.Detallar(objeto);

            if (cliente.Tarjeta != null)
            {
                foreach (BEL.Tarjeta tarjeta in cliente.Tarjeta)
                {
                    if (tarjeta is BEL.TarjetaNacional) ListaTarjetas.Add((BEL.TarjetaNacional)tarjeta);
                }
            }
            return ListaTarjetas;
        }

        // *---------------------------------------------------------------=> *

        private void DesasociarButton_Click(object sender, EventArgs e)
        {
            belCliente = (BEL.Cliente)ClientesDataGridView.CurrentRow.DataBoundItem;
            BEL.Cliente belClienteDetallado = bllCliente.Detallar(belCliente);

            if (TipoTextBox.Text == "Internacional")
            {
                belGiftcardInternacional.Codigo = Convert.ToInt32(CodigoTextBox.Text);
                belGiftcardInternacional.Numero = Convert.ToInt32(NumeroTextBox.Text);
                belGiftcardInternacional.Vencimiento = Convert.ToDateTime(FechaVencimientoTextBox.Text);
                belGiftcardInternacional.Saldo = Convert.ToInt32(SaldoTextBox.Text);
                belGiftcardInternacional.Descuento = Convert.ToInt32(DescuentosTextBox.Text);
                belGiftcardInternacional.Estado = EstadoTextBox.Text;
                belGiftcardInternacional.Rubro = RubroTextBox.Text;
                belGiftcardInternacional.Pais = PaisTextBox.Text;

                bllCliente.DesasociarGiftcardInternacional(belClienteDetallado, belGiftcardInternacional);
                belGiftcardInternacional.Estado = "Baja";
                belGiftcardInternacional.Saldo = 0;
                bllGiftcardInternacional.Guardar(belGiftcardInternacional);

                string message = "Operación correcta";
                string caption = "Información";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Information);
                InaugurarForm();
            }
            else if (TipoTextBox.Text == "Nacional")
            {
                belGiftcardNacional.Codigo = Convert.ToInt32(CodigoTextBox.Text);
                belGiftcardNacional.Numero = Convert.ToInt32(NumeroTextBox.Text);
                belGiftcardNacional.Vencimiento = Convert.ToDateTime(FechaVencimientoTextBox.Text);
                belGiftcardNacional.Saldo = Convert.ToInt32(SaldoTextBox.Text);
                belGiftcardNacional.Descuento = Convert.ToInt32(DescuentosTextBox.Text);
                belGiftcardNacional.Estado = EstadoTextBox.Text;
                belGiftcardNacional.Rubro = RubroTextBox.Text;
                belGiftcardNacional.Pais = PaisTextBox.Text;
                belGiftcardNacional.Provincia = ProvinciaTextBox.Text;

                bllCliente.DesasociarGiftcardNacional(belClienteDetallado, belGiftcardNacional);
                belGiftcardNacional.Estado = "Baja";
                belGiftcardNacional.Saldo = 0;
                bllGiftcardNacional.Guardar(belGiftcardNacional);

                string message = "Operación correcta";
                string caption = "Información";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Information);
                InaugurarForm();
            }
            else
            {
                string message = "Seleccione Gift Card a eliminar";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Error);
            }
        }

        private void AsociarButton_Click(object sender, EventArgs e)
        {
            belCliente = (BEL.Cliente)ClientesDataGridView.CurrentRow.DataBoundItem;
            BEL.Cliente belClienteDetallado = bllCliente.Detallar(belCliente);

            if (TextBox_Monto.Text != "")
            {

                if (VerificarEstadoTarjeta(oBEClienteAux) == true)
                {
                    if (DataGridView_Tarjetas_Int_Disponibles.SelectedRows.Count > 0)
                    {
                        oBETarjInt = (BETarjetaInternacional)DataGridView_Tarjetas_Int_Disponibles.CurrentRow.DataBoundItem;
                        if (oBETarjInt.Estado != "Baja")
                        {
                            oBETarjInt.Saldo = Convert.ToInt32(TextBox_Monto.Text);
                            oBETarjInt.Estado = "Alta";
                            oBlTarjetaInt.Guardar(oBETarjInt);
                            oBLCliente.AgregarTarjeta_Int_Cliente(oBEClienteAux, oBETarjInt);
                            CargarGrillaTarjDispInt();
                            oBEClienteAux2 = oBLCliente.ListarObjeto(oBEClienteAux);
                            CargarGrillaTarjCliInt(oBEClienteAux2);
                        }
                        else
                        {
                            MessageBox.Show("La tarjeta fue dada de baja, seleccione otra tarjeta");
                        }

                    }
                    else if (DataGridView_Tarjetas_Nac_Disponibles.SelectedRows.Count > 0)
                    {
                        if (oBETarjNac.Estado != "Baja")
                        {
                            oBETarjNac = (BETarjetaNacional)DataGridView_Tarjetas_Nac_Disponibles.CurrentRow.DataBoundItem;
                            oBETarjNac.Saldo = Convert.ToInt32(TextBox_Monto.Text);
                            oBETarjNac.Estado = "Alta";
                            oBLTarjetaNac.Guardar(oBETarjNac);
                            oBLCliente.AgregarTarjeta_Nac_Cliente(oBEClienteAux, oBETarjNac);
                            CargarGrillaTarjDispNac();
                            oBEClienteAux2 = oBLCliente.ListarObjeto(oBEClienteAux);
                            CargarGrillaTarjCliNac(oBEClienteAux2);
                        }
                        else
                        {
                            MessageBox.Show("La tarjeta fue dada de baja, seleccione otra tarjeta");
                        }


                    }
                }
                else
                {
                    MessageBox.Show("El cliente ya tiene una tarjeta dada de alta o la tarjeta no se puede asignar");
                }

            }
            else
            {
                MessageBox.Show("Ingrese el monto a cargar a la tarjeta");
            }

        }
    }
}
