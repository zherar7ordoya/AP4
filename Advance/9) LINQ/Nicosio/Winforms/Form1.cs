using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Winforms
{
    public partial class Form1 : Form
    {
        XDocument documento = new XDocument();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCargar_Click(object sender, EventArgs e)
        {
            documento = XDocument.Load("Alumnos.xml");
            txtXML.Text = documento.ToString();
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            XElement temporal = 
                new XElement("Alumno", new XAttribute("Nombre", txtNombre.Text),
                    new XElement("Curso", txtCurso.Text),
                    new XElement("Calificación", txtCalificacion.Text)
                );
            documento.Descendants("Alumnos").Last().Add(temporal);
            txtXML.Text = documento.ToString();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            var resultados = from a in documento.Descendants("Alumno")
                             where (string)a.Element("Curso") == txtBusqueda.Text
                             select a.Element("Calificacion").Value+ a.Element("Curso").Value;
            string datos = "";
            foreach (var dato in resultados.Distinct()) datos += string.Format($"Calificación {dato}\n");
            MessageBox.Show(datos);
        }

        private void CmdGuardar_Click(object sender, EventArgs e)
        {
            documento.Save("Alumnos.xml");
            MessageBox.Show("Done!");
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            documento.Descendants("Alumno").Remove();
            txtXML.Text = documento.ToString();
        }
    }
}
