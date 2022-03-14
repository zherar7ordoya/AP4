using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events_Using_EventArgs_Class
{
    public partial class Publicador : Form
    {
        private Evento evento;
        private Suscriptor suscriptor;

        public Publicador()
        {
            InitializeComponent();
            evento = new Evento();
        }

        private void NewWinformButton_Click(object sender, EventArgs e)
        {
            suscriptor = new Suscriptor();
            suscriptor.Show();
        }

        private void MétodoEnPublicador(object sender, Evento e) => TextBox.Text = e.Mensaje.ToString();

        private void BienvenidaButton_Click(object sender, EventArgs e)
        {
            Evento.manejador -= MétodoEnPublicador;
            Evento.manejador += MétodoEnPublicador;
            evento.EnviarMensaje("Welcome!");
        }

        private void DespedidaButton_Click(object sender, EventArgs e)
        {
            Evento.manejador -= MétodoEnPublicador;
            Evento.manejador += MétodoEnPublicador;
            evento.EnviarMensaje("Goodbye...");
        }
    }
}
