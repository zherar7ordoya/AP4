using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UI
{
    public partial class JugadorRegistroForm : Form
    {
        /* ----------------------------------------------------------------- *\
         * ARRANQUE                                                          *
        \* ----------------------------------------------------------------- */

        private XDocument documentox;
        private readonly string archivo = "Jugadores.xml";
        private List<BE.Jugador> jugadores;

        //

        public JugadorRegistroForm()
        {
            InitializeComponent();
            jugadores = new List<BE.Jugador>();
        }

        private void JugadorRegistroForm_Load(object sender, EventArgs e) => CargarJugadores();

        /* ----------------------------------------------------------------- *\
         * COMUNES                                                           *
        \* ----------------------------------------------------------------- */

        public void CargarJugadores()
        {
            try
            {
                documentox = XDocument.Load(archivo);

                //var datos = documentox.Descendants("Jugador").Select(x => new
                //{
                //    Codigo = x.Attribute("Codigo").Value,
                //    Nombre = x.Element("Nombre").Value,
                //    Apellido = x.Element("Apellido").Value,
                //    DNI = x.Element("DNI").Value,
                //    Email = x.Element("Email").Value,
                //    FechaNacimiento = x.Element("FechaNacimiento").Value,
                //    LocalidadResidencia = x.Element("LocalidadResidencia").Value
                //}).OrderBy(x => Convert.ToInt32(x.Codigo)).ToList();

                jugadores = (List<BE.Jugador>)documentox.Descendants("Jugador").Select(x => new BE.Jugador
                {
                    Codigo = Convert.ToInt32(x.Attribute("Codigo").Value),
                    Nombre = x.Element("Nombre").Value,
                    Apellido = x.Element("Apellido").Value,
                    DNI = Convert.ToInt32(x.Element("DNI").Value),
                    Email = x.Element("Email").Value,
                    FechaNacimiento = Convert.ToDateTime(x.Element("FechaNacimiento").Value),
                    LocalidadResidencia = x.Element("LocalidadResidencia").Value
                }).OrderBy(x => Convert.ToInt32(x.Codigo)).ToList();

                CodigoTextbox.DataBindings.Clear();
                NombreTextbox.DataBindings.Clear();
                ApellidoTextbox.DataBindings.Clear();
                DniTextbox.DataBindings.Clear();
                EmailTextbox.DataBindings.Clear();
                NacimientoDTP.DataBindings.Clear();
                LocalidadTextbox.DataBindings.Clear();



                CodigoTextbox.DataBindings.Add("text", jugadores, "Codigo");
                NombreTextbox.DataBindings.Add("text", jugadores, "Nombre");
                ApellidoTextbox.DataBindings.Add("text", jugadores, "Apellido");
                DniTextbox.DataBindings.Add("text", jugadores, "DNI");
                EmailTextbox.DataBindings.Add("text", jugadores, "Email");
                NacimientoDTP.DataBindings.Add("text", jugadores, "FechaNacimiento");
                LocalidadTextbox.DataBindings.Add("text", jugadores, "LocalidadResidencia");

                //JugadoresDGV.DataSource = datos;
                JugadoresDGV.DataSource = jugadores;
                JugadoresDGV.Columns["Codigo"].DisplayIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in DetalleGroupbox.Controls)
                {
                    if (item is TextBox) (item as TextBox).Clear();
                    if (item is DateTimePicker) (item as DateTimePicker).Text = string.Empty;
                }
                JugadoresDGV.Enabled = false;
                ModificacionButton.Enabled = false;
                BajaButton.Enabled = false;
                AltaButton.Enabled = true;
                CancelarButton.Enabled = true;
                CodigoTextbox.Enabled = true;
                CodigoTextbox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            try
            {
                JugadoresDGV.Enabled = true;
                ModificacionButton.Enabled = true;
                BajaButton.Enabled = true;
                AltaButton.Enabled = false;
                CancelarButton.Enabled = false;
                CodigoTextbox.Enabled = false;
                CargarJugadores();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /* ----------------------------------------------------------------- *\
         * ABM                                                               *
        \* ----------------------------------------------------------------- */

        private void AltaButton_Click(object sender, EventArgs e)
        {
            try
            {
                XElement registro =
                    documentox
                    .Descendants("Jugador")
                    .FirstOrDefault
                    (x => x.Attribute("Codigo").Value == CodigoTextbox.Text);

                if (registro is null)
                {
                    XElement jugador =
                    new XElement("Jugador",
                    new XAttribute("Codigo", CodigoTextbox.Text),
                    new XElement("Nombre", NombreTextbox.Text),
                    new XElement("Apellido", ApellidoTextbox.Text),
                    new XElement("DNI", DniTextbox.Text),
                    new XElement("Email", EmailTextbox.Text),
                    new XElement("FechaNacimiento", NacimientoDTP.Text),
                    new XElement("LocalidadResidencia", LocalidadTextbox.Text)
                    );

                    documentox.Root.Add(jugador);
                    documentox.Save(archivo);

                    JugadoresDGV.Enabled = true;
                    ModificacionButton.Enabled = true;
                    BajaButton.Enabled = true;
                    AltaButton.Enabled = false;
                    CancelarButton.Enabled = false;
                    CodigoTextbox.Enabled = false;
                    CargarJugadores();
                }
                else
                {
                    MessageBox.Show(
                        "Existe registro",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //

        private void BajaButton_Click(object sender, EventArgs e)
        {
            try
            {
                XElement jugador =
                    documentox
                    .Descendants("Jugador")
                    .FirstOrDefault
                    (x => x.Attribute("Codigo").Value == CodigoTextbox.Text);

                if (jugador != null)
                {
                    jugador.Remove();
                    documentox.Save(archivo);
                    CargarJugadores();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        //

        private void ModificacionButton_Click(object sender, EventArgs e)
        {
            try
            {
                XElement jugador =
                    documentox
                    .Descendants("Jugador")
                    .FirstOrDefault
                    (x => x.Attribute("Codigo").Value == CodigoTextbox.Text);

                if (jugador != null)
                {
                    jugador.Element("Nombre").Value = NombreTextbox.Text;
                    jugador.Element("Apellido").Value = ApellidoTextbox.Text;
                    jugador.Element("DNI").Value = DniTextbox.Text;
                    jugador.Element("Email").Value = EmailTextbox.Text;
                    jugador.Element("FechaNacimiento").Value = NacimientoDTP.Text;
                    jugador.Element("LocalidadResidencia").Value = LocalidadTextbox.Text;
                    documentox.Save(archivo);
                    CargarJugadores();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        /* ----------------------------------------------------------------- *\
         * FINAL                                                             *
        \* ----------------------------------------------------------------- */

    }
}
