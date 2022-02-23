using System;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ModeloNegocio.People.Get();
            textBox1.Text = Services.Service.GetPost();
        }
    }
}
