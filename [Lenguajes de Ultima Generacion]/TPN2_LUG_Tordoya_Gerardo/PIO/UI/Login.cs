using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Login : Form
    {
        // *-----------------------------------------------------------=> ROBOT

        public Login() => InitializeComponent();
        private void XButton_Click(object sender, EventArgs e) => this.Close();

        // *----------------------------------------------------------=> HUMANO
                
        private void ContraseñaTextBox_TextChanged(object sender, EventArgs e)
        {
            HashTextBox.Text = SECURITY.Criptografia.Encriptar(ContraseñaTextBox.Text);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string encriptado = SECURITY.Criptografia.Encriptar(ContraseñaTextBox.Text);
            UsuarioTextBox.Text = SECURITY.Criptografia.Desencriptar(encriptado);
        }
    }
}
