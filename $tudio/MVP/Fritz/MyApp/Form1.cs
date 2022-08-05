using System;
using System.Windows.Forms;
using Core;

namespace MyApp
{
    public partial class Form1 : Form, ICalculadoraVista
    {
        private readonly Presentador PRESENTADOR;

        public string Pantalla
        {
            get => PantallaTextbox.Text;
            set { PantallaTextbox.Text = value; }
        }

        public Form1()
        {
            InitializeComponent();
            PRESENTADOR = new Presentador(this);
        }

        private void Numero_Click(object sender, EventArgs e) => PRESENTADOR.BotonNumeroPresionado((sender as Button).Text);
        private void Operador_Click(object sender, EventArgs e) => PRESENTADOR.BotonOperadorPresionado((sender as Button).Text);
        private void Limpieza_Click(object sender, EventArgs e) => PRESENTADOR.BotonLimpiezaPresionado();
    }
}