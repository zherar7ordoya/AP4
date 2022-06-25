using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RebootReportes
{
    public partial class GraficoFormulario : Form
    {
        public GraficoFormulario() => InitializeComponent();

        readonly List<Persona> Personas = new List<Persona>();

        void CargarLista()
        {

            Personas.Add(new Persona() { Codigo = 1, Nombre = "Juan", Apellido = "Perez", Sueldo = 70000 });
            Personas.Add(new Persona() { Codigo = 2, Nombre = "Pedro", Apellido = "Fernandez", Sueldo = 70000 });
            Personas.Add(new Persona() { Codigo = 3, Nombre = "Jose", Apellido = "Gonzalez", Sueldo = 50000 });
            Personas.Add(new Persona() { Codigo = 4, Nombre = "Martin", Apellido = "Garcia", Sueldo = 170000 });
            Personas.Add(new Persona() { Codigo = 5, Nombre = "Roman", Apellido = "Riquelme", Sueldo = 180000 });
            Personas.Add(new Persona() { Codigo = 6, Nombre = "Analia", Apellido = "Lopez", Sueldo = 40000 });
            Personas.Add(new Persona() { Codigo = 7, Nombre = "Lorena", Apellido = "Legrand", Sueldo = 15000 });
            Personas.Add(new Persona() { Codigo = 8, Nombre = "Maria", Apellido = "DelCerro", Sueldo = 39000 });
            Personas.Add(new Persona() { Codigo = 9, Nombre = "Fernanda", Apellido = "Parente", Sueldo = 50000 });
            Personas.Add(new Persona() { Codigo = 10, Nombre = "Ignacio", Apellido = "Claus", Sueldo = 70000 });
        }

        void CargarGraficoListas()
        {
            CargarLista();

            Dictionary<string, double> ListaDatos = new Dictionary<string, double>();

            foreach (Persona item in Personas)
            {
                Persona persona = item;
                ListaDatos.Add(persona.Apellido, persona.Sueldo);
            }


            //inicializo los valores del titulo,  area y serie
            UnicoChart.Titles.Clear();
            UnicoChart.ChartAreas.Clear();
            UnicoChart.Series.Clear();

            //agrego el titulo
            Title Titulo = new Title("Chart enlazado con Listas")
            {
                Font = new Font("Tahoma", 20, FontStyle.Bold)
            };
            UnicoChart.Titles.Add(Titulo);

            //creo el area y habilito el gráfico en 3D
            ChartArea Area = new ChartArea();
            //Area.Area3DStyle.Enable3D = true;
            UnicoChart.ChartAreas.Add(Area);

            //agrego la serie
            Series serie = new Series("Sueldo")
            {
                //digo q tipo de grafico quiero 
                ChartType = SeriesChartType.Bar
            };
            serie.Points.DataBindXY(ListaDatos.Keys, ListaDatos.Values);

            UnicoChart.Series.Add(serie);

        }

        private void GraficoFormulario_Load(object sender, EventArgs e) => CargarGraficoListas();
    }
}
