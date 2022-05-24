using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace EscritorioClasico.Compras
{
    public partial class ComprasForm : Form
    {
        // *-------------------------------------------------------=> SINGLETON
        private ComprasForm() => InitializeComponent();
        private static ComprasForm instancia = null;
        public static ComprasForm Instancia()
        {
            if (instancia == null) instancia = new ComprasForm();
            return instancia;
        }
        private void ComprasForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        // *----------------------------------------------------=> INAUGURACIÓN

        private void ComprasForm_Load(object sender, EventArgs e) => InauguraForm();

        BLL.Cliente bllCliente = new BLL.Cliente();
        BEL.Cliente belCliente = new BEL.Cliente();

        

        private void InauguraForm()
        {
            this.ClientesDataGridView.DataSource = null;
            this.ClientesDataGridView.Rows.Clear();
            this.ClientesDataGridView.DataSource = bllCliente.Listar();
        }



        

        private void ComprasDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            belCliente = (BEL.Cliente)DataGridView_Clientes.CurrentRow.DataBoundItem;
            AsignarTarjetaATextBox(belCliente);
        }
        private void AsignarTarjetaATextBox(BEL.Cliente ClieAux)
        {
            BEL.Cliente ClieAux2 = bllCliente.Detallar(ClieAux);
            BEL.Tarjeta oBETarjAux = TarjetaDeAlta(ClieAux2);
            if (oBETarjAux != null)
            {
                TextBox_Numero_Tarjeta.Text = oBETarjAux.Numero.ToString();
                TextBox_Saldo_Tarjeta.Text = oBETarjAux.Saldo.ToString();
            }
            else
            {
                TextBox_Numero_Tarjeta.Text = "NO";
                TextBox_Saldo_Tarjeta.Text = "NO";
            }
        }



        private BEL.Tarjeta TarjetaDeAlta(BEL.Cliente ClieAux)
        {
            BEL.Tarjeta oBETarjAux = null;
            if (ClieAux.Tarjeta != null)
            {
                foreach (BEL.Tarjeta Tarj in ClieAux.Tarjeta)
                {
                    if (Tarj.Estado == "Alta")
                    {
                        oBETarjAux = Tarj;
                    }
                }
            }
            return oBETarjAux;
        }
















        BEL.TarjetaInternacional belGiftcardInternacional = new BEL.TarjetaInternacional();
        BEL.TarjetaNacional belGiftcardNacional = new BEL.TarjetaNacional();

        BLL.TarjetaInternacional bllGiftcardInternacional = new BLL.TarjetaInternacional();
        BLL.TarjetaNacional bllGiftcardNacional = new BLL.TarjetaNacional();

        private void RegistrarButton_Click(object sender, EventArgs e)
        {
            belGiftcardInternacional = null;
            belGiftcardNacional = null;
            BEL.Cliente belClienteAux = (BEL.Cliente)DataGridView_Clientes.CurrentRow.DataBoundItem;
            belCliente = bllCliente.Detallar(belCliente);
            BEL.Tarjeta oBEtarjeta = TarjetaDeAlta(belCliente);
            List<BEL.TarjetaInternacional> ListaTarjetasInt = bllGiftcardInternacional.Listar();
            List<BEL.TarjetaNacional> ListaTarjetasNac = bllGiftcardNacional.Listar();

            int MontoCompra = Convert.ToInt32(TextBox_Monto_compra.Text);
            int MontoTarjeta = Convert.ToInt32(TextBox_Saldo_Tarjeta.Text);

            if (oBEtarjeta != null)
            {
                foreach (BEL.TarjetaInternacional belGiftcardInternacionalAux in ListaTarjetasInt)
                {
                    if (oBEtarjeta.Codigo == belGiftcardInternacionalAux.Codigo)
                    {
                        belGiftcardInternacional = belGiftcardInternacionalAux;
                    }
                }
                foreach (BEL.TarjetaNacional belGiftcardNacionalAux in ListaTarjetasNac)
                {
                    if (oBEtarjeta.Codigo == belGiftcardNacionalAux.Codigo)
                    {
                        belGiftcardNacional = belGiftcardNacionalAux;
                    }
                }
                if (MontoCompra <= MontoTarjeta)
                {
                    if (belGiftcardInternacional != null)
                    {
                        oBEDesc.DescuentoOtorgado = bllGiftcardInternacional.ObtenerDescuento(MontoCompra);
                        oBEDesc.NumeroTarjeta = belGiftcardInternacional.Numero;
                        oBEDesc.Tipo = "Internacional";
                        oBLDesc.Guardar(oBEDesc);

                        belGiftcardInternacional.Saldo = belGiftcardInternacional.Saldo - MontoCompra;
                        if (belGiftcardInternacional.Saldo == 0)
                        {
                            belGiftcardInternacional.Estado = "Sin Saldo";
                        }
                        bllGiftcardInternacional.Guardar(belGiftcardInternacional);
                    }
                    else if (belGiftcardNacional != null)
                    {
                        oBEDesc.DescuentoOtorgado = bllGiftcardNacional.ObtenerDescuento(MontoCompra);
                        oBEDesc.NumeroTarjeta = belGiftcardNacional.Numero;
                        oBEDesc.Tipo = "Nacional";
                        oBLDesc.Guardar(oBEDesc);
                        belGiftcardNacional.Saldo = belGiftcardNacional.Saldo - MontoCompra;
                        if (belGiftcardNacional.Saldo == 0)
                        {
                            belGiftcardNacional.Estado = "Sin Saldo";
                        }
                        bllGiftcardNacional.Guardar(belGiftcardNacional);
                    }
                }
                else
                {
                    MessageBox.Show("No hay saldo suficiente");
                }
            }
            else
            {
                MessageBox.Show("El cliente no tiene tarjeta dada de alta");
            }
            Limpiar();
        }



        void Limpiar()
        {
            List<TextBox> ListTxtBox = new List<TextBox>();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)ctrl).Text = String.Empty;
                }
            }
        }




    }
}
