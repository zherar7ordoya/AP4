using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace EscritorioClasico.ABMs
{
    public partial class GiftcardsForm : Form
    {
        //APP-1
        BEL.Tarjeta giftcard = new BEL.Tarjeta();
        BLL.TarjetaInternacional giftcardInternacional = new BLL.TarjetaInternacional();
        BLL.TarjetaNacional giftcardNacional = new BLL.TarjetaNacional();
        BLL.DescuentoCalculado descuento = new BLL.DescuentoCalculado();
        List<BEL.TarjetaInternacional> ListaInternacionales = new List<BEL.TarjetaInternacional>();
        List<BEL.TarjetaNacional> ListaNacionales = new List<BEL.TarjetaNacional>();
        List<BEL.DescuentoCalculado> ListaDescuentos = new List<BEL.DescuentoCalculado>();

        #region *--------------------------------------------------=> SINGLETON
        private GiftcardsForm() => InitializeComponent();

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
            if (respuesta == DialogResult.OK) MessageBox.Show("DialogResult: OK");
        }

        private void GiftcardsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
        #endregion
        

        //APP-3
        private void GiftcardsForm_Load(object sender, EventArgs e)
        {
            this.InternacionalesDataGridView.DataSource = null;
            this.InternacionalesDataGridView.Rows.Clear();
            this.InternacionalesDataGridView.DataSource = giftcardInternacional.Listar();
            this.InternacionalesDataGridView.Columns["Pais"].DisplayIndex = 2;

            this.NacionalesDataGridView.DataSource = null;
            this.NacionalesDataGridView.Rows.Clear();
            this.NacionalesDataGridView.DataSource = giftcardNacional.Listar();
            this.NacionalesDataGridView.Columns["Provincia"].DisplayIndex = 2;

            GiftcardMenorSaldo();
            GiftcardMayorDescuento();
        }


        private void GiftcardMenorSaldo()
        {
            ListaInternacionales = giftcardInternacional.Listar();
            ListaNacionales = giftcardNacional.Listar();

            giftcard.Saldo = 999999;

            if (ListaInternacionales != null)
            {
                foreach (BEL.TarjetaInternacional item in ListaInternacionales)
                {
                    if (item.Saldo < giftcard.Saldo && item.Saldo != 0) giftcard = item;
                }
                InternacionalesMenorSaldoTextBox.Text = $"Gift Card {giftcard.Numero} || Saldo: {giftcard.Saldo:C}";
            }
            else { InternacionalesMenorSaldoTextBox.Text = "(Sin datos disponibles)"; }

            giftcard.Saldo = 999999;

            if (ListaNacionales != null)
            {
                foreach (BEL.TarjetaNacional item in ListaNacionales)
                {
                    if (item.Saldo < giftcard.Saldo && item.Saldo != 0) giftcard = item;
                }
                NacionalesMenorSaldoTextBox.Text = $"Gift Card {giftcard.Numero} || Saldo: {giftcard.Saldo:C}";
            }
            else { NacionalesMenorSaldoTextBox.Text = "(Sin datos disponibles)"; }
        }


        private void GiftcardMayorDescuento()
        {
            ListaDescuentos = descuento.Listar();
            double iDescuento = 0, nDescuento = 0;
            int iGiftcard = 0, nGiftcard = 0;

            if (ListaDescuentos != null)
            {
                foreach (BEL.DescuentoCalculado item in ListaDescuentos)
                {

                    if (item.Tipo == "Internacional")
                    {
                        if (iDescuento < item.DescuentoOtorgado)
                        {
                            iGiftcard = item.NumeroTarjeta;
                            iDescuento = item.DescuentoOtorgado;
                        }
                    }

                    if (item.Tipo == "Nacional")
                    {
                        if (nDescuento < item.DescuentoOtorgado)
                        {
                            nGiftcard = item.NumeroTarjeta;
                            nDescuento = item.DescuentoOtorgado;
                        }
                    }
                }
                InternacionalesMayorDescuentoTextBox.Text = $"Gift Card: {iGiftcard} || Descuento: {iDescuento:C}";
                NacionalesMayorDescuentoTextBox.Text = $"Gift Card: {nGiftcard} || Descuento: {nDescuento:C}";
            }
            else
            {
                InternacionalesMayorDescuentoTextBox.Text = "(Sin datos disponibles)";
                NacionalesMayorDescuentoTextBox.Text = "(Sin datos disponibles)";
            }
        }

        // *------------------------------------------=> FINALIZA CARGA INICIAL


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
    }
}
