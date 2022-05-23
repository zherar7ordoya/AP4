using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace EscritorioClasico.ABMs
{
    public partial class GiftcardsForm : Form
    {
        //APP-1
        BLL.TarjetaInternacional internacional;
        BLL.TarjetaNacional nacional;

        // *-------------------------------------------------------=> SINGLETON
        private GiftcardsForm()
        {
            InitializeComponent();

            //APP-2
            internacional = new BLL.TarjetaInternacional();
            nacional = new BLL.TarjetaNacional();
        }

        private static GiftcardsForm instancia = null;

        public static GiftcardsForm Instancia()
        {
            if (instancia == null) instancia = new GiftcardsForm();
            return instancia;
        }

        private void AltaGitfcardButton_Click(object sender, EventArgs e)
        {
            GiftcardForm formulario = GiftcardForm.Instancia();
            DialogResult respuesta = formulario.ShowDialog();
            if (respuesta == DialogResult.OK)
            {
                MessageBox.Show("DialogResult: OK");
            }
        }

        private void GiftcardsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
        // *-------------------------------------------------------=> *********


        //APP-3
        private void GiftcardsForm_Load(object sender, EventArgs e)
        {
            this.InternacionalesDataGridView.DataSource = null;
            this.InternacionalesDataGridView.Rows.Clear();
            this.InternacionalesDataGridView.DataSource = internacional.Listar();

            this.NacionalesDataGridView.DataSource = null;
            this.NacionalesDataGridView.Rows.Clear();
            this.NacionalesDataGridView.DataSource = nacional.Listar();

            CalcularTarjetaMayorDescuento();
            TarjetaMenorMonto();
        }

        private void InternacionalesDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0) MessageBox.Show(InternacionalesDataGridView[(e.ColumnIndex + 3), e.RowIndex].Value.ToString() + ": estás a punto de borrar.");
                if (e.ColumnIndex == 1) MessageBox.Show(InternacionalesDataGridView[(e.ColumnIndex + 2), e.RowIndex].Value.ToString() + ": vas a editar...");
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                string caption = "Informe de Excepciones";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
            }
        }

        private void NacionalesDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0) MessageBox.Show(NacionalesDataGridView[(e.ColumnIndex + 3), e.RowIndex].Value.ToString() + ": estás a punto de borrar.");
                if (e.ColumnIndex == 1) MessageBox.Show(NacionalesDataGridView[(e.ColumnIndex + 2), e.RowIndex].Value.ToString() + ": vas a editar...");
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                string caption = "Informe de Excepciones";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(
                    message,
                    caption,
                    buttons,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.RightAlign);
            }
        }





        BLL.DescuentoCalculado oBLDesc = new BLL.DescuentoCalculado();
        BLL.TarjetaNacional oBLTarjetaNac = new BLL.TarjetaNacional();
        BLL.TarjetaInternacional oBLTarjetaInt = new BLL.TarjetaInternacional();




        private void TarjetaMenorMonto()
        {
            BEL.Tarjeta oBETarjAux = new BEL.Tarjeta();
            oBETarjAux.Saldo = 999999;
            List<BEL.TarjetaNacional> ListaTarjetasNac = oBLTarjetaNac.Listar();
            List<BEL.TarjetaInternacional> ListaTarjetasInt = oBLTarjetaInt.Listar();


            if (ListaTarjetasNac != null)
            {
                foreach (BEL.TarjetaNacional oBETarjNacAux in ListaTarjetasNac)
                {
                    if (oBETarjNacAux.Saldo < oBETarjAux.Saldo && oBETarjNacAux.Saldo != 0)
                    {
                        oBETarjAux = oBETarjNacAux;
                    }
                }
            }


            if (ListaTarjetasInt != null)
            {
                foreach (BEL.TarjetaInternacional oBETarjIntAux in ListaTarjetasInt)
                {
                    if (oBETarjIntAux.Saldo < oBETarjAux.Saldo && oBETarjIntAux.Saldo != 0)
                    {
                        oBETarjAux = oBETarjIntAux;
                    }
                }
            }
            InternacionalesMenorSaldoTextBox.Text = "Gift Card " + oBETarjAux.Numero + " || Saldo: $" + oBETarjAux.Saldo;
        }




        private void CalcularTarjetaMayorDescuento()
        {
            List<BEL.DescuentoCalculado> ListaDescuentos = oBLDesc.Listar();
            List<BEL.TarjetaNacional> ListaTarjetasNac = oBLTarjetaNac.Listar();
            List<BEL.TarjetaInternacional> ListaTarjetasInt = oBLTarjetaInt.Listar();
            double aux1 = 0;
            double aux = 0;
            int numeroTarjeta = 0;
            BEL.Tarjeta oBETarjAux = new BEL.Tarjeta();
            if (ListaDescuentos != null)
            {
                foreach (BEL.DescuentoCalculado oBEDesAux in ListaDescuentos)
                {
                    aux1 += oBEDesAux.DescuentoOtorgado;
                    numeroTarjeta = oBEDesAux.NumeroTarjeta;

                    foreach (BEL.DescuentoCalculado oBEDesAux2 in ListaDescuentos)
                    {
                        if (oBEDesAux.NumeroTarjeta == oBEDesAux2.NumeroTarjeta && oBEDesAux.DescuentoOtorgado != oBEDesAux2.DescuentoOtorgado)
                        {
                            aux1 += oBEDesAux2.DescuentoOtorgado;
                        }
                    }
                    if (aux1 > aux)
                    {
                        aux = aux1;
                        aux1 = 0;
                    }
                }
                InternacionalesMayorDescuentoTextBox.Text = "Gift Card: " + numeroTarjeta.ToString() + " || Descuento: $" + aux;
            }
            else
            {
                InternacionalesMayorDescuentoTextBox.Text = "No hay descuentos acumulados";
            }
        }





    }
}
