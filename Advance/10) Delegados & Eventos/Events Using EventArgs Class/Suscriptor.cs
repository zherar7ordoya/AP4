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
    public partial class Suscriptor : Form
    {
        public Suscriptor()
        {
            InitializeComponent();
            Evento.manejador -= MétodoEnSuscriptor;
            Evento.manejador += MétodoEnSuscriptor;
        }

        private void MétodoEnSuscriptor(object sender, Evento e)
        {
            TextBox.Text = e.Mensaje.ToString();
        }
    }
}
