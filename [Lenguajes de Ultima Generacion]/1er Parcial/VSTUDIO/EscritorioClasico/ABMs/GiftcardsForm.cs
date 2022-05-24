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
        private void GiftcardsForm_Load(object sender, EventArgs e) => CargaInicial();

        private void CargaInicial()
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


        BEL.TarjetaInternacional belGiftcardInternacional = new BEL.TarjetaInternacional();
        BLL.TarjetaInternacional lgcGiftcardInternacional = new BLL.TarjetaInternacional();

        private void InternacionalesDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            belGiftcardInternacional = (BEL.TarjetaInternacional)this.InternacionalesDataGridView.CurrentRow.DataBoundItem;

            try
            {
                // ELIMINA
                if (e.ColumnIndex == 0)
                {
                    DialogResult respuesta;
                    respuesta = MessageBox.Show("¿Confirma eliminación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        if (lgcGiftcardInternacional.Eliminar(belGiftcardInternacional) == false) MessageBox.Show("Registro asociado", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        else { CargaInicial(); }
                    }
                }

                // EDITA
                if (e.ColumnIndex == 1)
                {
                    GiftcardForm formulario = new GiftcardForm();

                    formulario.CodigoTextBox.Text = belGiftcardInternacional.Codigo.ToString();
                    formulario.CodigoTextBox.Enabled = false;

                    formulario.NumeroTextBox.Text = belGiftcardInternacional.Numero.ToString();
                    formulario.FechaVencimientoDateTimePicker.Value = belGiftcardInternacional.Vencimiento;
                    formulario.RubroComboBox.Text = belGiftcardInternacional.Rubro.ToString();
                    formulario.PaisComboBox.Text = belGiftcardInternacional.Pais.ToString();

                    formulario.ProvinciaComboBox.Text = String.Empty;
                    formulario.ProvinciaComboBox.Enabled = false;

                    DialogResult respuesta = formulario.ShowDialog();
                    if (respuesta == DialogResult.OK) CargaInicial();
                }
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


        BEL.TarjetaNacional belGiftcardNacional = new BEL.TarjetaNacional();
        BLL.TarjetaNacional lgcGiftcardNacional = new BLL.TarjetaNacional();

        private void NacionalesDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            belGiftcardNacional = (BEL.TarjetaNacional)this.NacionalesDataGridView.CurrentRow.DataBoundItem;

            try
            {
                // ELIMINA
                if (e.ColumnIndex == 0)
                {
                    DialogResult respuesta;
                    respuesta = MessageBox.Show("¿Confirma eliminación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        if (lgcGiftcardNacional.Eliminar(belGiftcardNacional) == false) MessageBox.Show("Registro asociado", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        else { CargaInicial(); }
                    }
                }

                // EDITA
                if (e.ColumnIndex == 1)
                {
                    GiftcardForm formulario = new GiftcardForm();

                    formulario.CodigoTextBox.Text = belGiftcardNacional.Codigo.ToString();
                    formulario.CodigoTextBox.Enabled = false;

                    formulario.NumeroTextBox.Text = belGiftcardNacional.Numero.ToString();
                    formulario.FechaVencimientoDateTimePicker.Value = belGiftcardNacional.Vencimiento;
                    formulario.RubroComboBox.Text = belGiftcardNacional.Rubro.ToString();
                    formulario.PaisComboBox.Text = belGiftcardNacional.Pais.ToString();
                    formulario.ProvinciaComboBox.Text = belGiftcardNacional.Provincia.ToString();

                    DialogResult respuesta = formulario.ShowDialog();
                    if (respuesta == DialogResult.OK) CargaInicial();
                }
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
