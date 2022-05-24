﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EscritorioClasico.ABMs
{
    public partial class GiftcardForm : Form
    {
        // *-------------------------------------------------------=> SINGLETON
        public GiftcardForm() => InitializeComponent();
        private static GiftcardForm instancia = null;
        public static GiftcardForm Instancia()
        {
            if (instancia == null) instancia = new GiftcardForm();
            return instancia;
        }
        // *-------------------------------------------------------=> *********

        private void GiftcardForm_FormClosing(object sender, FormClosingEventArgs e) => LimpiarTextBoxes();

        private void LimpiarTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox) (control as TextBox).Clear();
                    else { func(control.Controls); }
                }
            };
            func(Controls);
        }

        private void GiftcardForm_Load(object sender, EventArgs e)
        {
            CargarPaises();
            CargarProvincias();
        }

        // *---------------------------------------------------------------=> *


        private void RegistrarButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PaisComboBox.Text != "Argentina")
                {
                    BLL.TarjetaInternacional lgcGiftcard = new BLL.TarjetaInternacional();
                    BEL.TarjetaInternacional belGiftcard = new BEL.TarjetaInternacional();
                    
                    if (CodigoTextBox.Text != "") belGiftcard.Codigo = Convert.ToInt32(CodigoTextBox.Text);
                    else { belGiftcard.Codigo = 0; }

                    belGiftcard.Numero = Convert.ToInt32(NumeroTextBox.Text);
                    belGiftcard.Vencimiento = FechaVencimientoDateTimePicker.Value;
                    belGiftcard.Rubro = RubroComboBox.Text;
                    belGiftcard.Pais = PaisComboBox.Text;
                    ProvinciaComboBox.Text = string.Empty;

                    lgcGiftcard.Guardar(belGiftcard);
                }

                if (PaisComboBox.Text == "Argentina")
                {
                    BLL.TarjetaNacional lgcGiftcard = new BLL.TarjetaNacional();
                    BEL.TarjetaNacional belGiftcard = new BEL.TarjetaNacional();

                    if (CodigoTextBox.Text != "") belGiftcard.Codigo = Convert.ToInt32(CodigoTextBox.Text);
                    else { belGiftcard.Codigo = 0; }

                    belGiftcard.Numero = Convert.ToInt32(NumeroTextBox.Text);
                    belGiftcard.Vencimiento = FechaVencimientoDateTimePicker.Value;
                    belGiftcard.Rubro = RubroComboBox.Text;
                    belGiftcard.Pais = "Argentina";
                    belGiftcard.Provincia = ProvinciaComboBox.Text;

                    lgcGiftcard.Guardar(belGiftcard);
                }
                LimpiarTextBoxes();
                this.DialogResult = DialogResult.OK;
                this.Close();
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


        BLL.Pais lgcPais = new BLL.Pais();

        private void CargarPaises()
        {
            PaisComboBox.DataSource = null;

            List<BEL.Pais> ListaPaises = lgcPais.Listar();
            List<string> paises = new List<string>();
            foreach (BEL.Pais pais in ListaPaises) paises.Add(pais.Nombre);
            PaisComboBox.DataSource = paises;
            PaisComboBox.DisplayMember = "Nombre";
            PaisComboBox.Refresh();
        }


        BLL.Provincia lgcProvincia = new BLL.Provincia();

        private void CargarProvincias()
        {
            ProvinciaComboBox.DataSource = null;

            List<BEL.Provincia> ListaProvincias = lgcProvincia.Listar();
            List<string> provincias = new List<string>();
            foreach (BEL.Provincia provincia in ListaProvincias) provincias.Add(provincia.Nombre);
            ProvinciaComboBox.DataSource = provincias;
            ProvinciaComboBox.DisplayMember = "Nombre";
            ProvinciaComboBox.Refresh();
        }
    }
}
