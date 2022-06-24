using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RebootReportes
{
    public partial class InformeList : Form
    {
        public InformeList()
        {
            InitializeComponent();
        }

        private void InformeList_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            CargarReporte();
        }

        //|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

        private List<Persona> CargarPersonas()
        {
            List<Persona> ListaPersona = new List<Persona>();
            Persona op1 = new Persona(1, "Juan",    "Perez",    20345678, "juan@algo.com",      Convert.ToDateTime("10/10/1980"));
            Persona op2 = new Persona(2, "Pedro",   "Lopez",    27345678, "pedrito@algo.com",   Convert.ToDateTime("16/09/1989"));
            Persona op3 = new Persona(3, "Analia",  "Sanchez",  33987459, "anita@algo.com",     Convert.ToDateTime("30/08/1999"));
            Persona op4 = new Persona(4, "Julieta", "Capuleto", 35113936, "jula@algo.com",      Convert.ToDateTime("11/11/2000"));
            Persona op5 = new Persona(5, "Romeo",   "Montesco", 29085312, "romeo@algo.com",     Convert.ToDateTime("10/10/2007"));
            Persona op6 = new Persona(6, "Lorena",  "Ramish",   28999742, "lorena@algo.com",    Convert.ToDateTime("13/04/1979"));
            Persona op7 = new Persona(7, "Gerardo", "Tordoya",  39345678, "sergio@algo.com",    Convert.ToDateTime("10/01/2005"));

            ListaPersona.Add(op1);
            ListaPersona.Add(op2);
            ListaPersona.Add(op3);
            ListaPersona.Add(op4);
            ListaPersona.Add(op5);
            ListaPersona.Add(op6);
            ListaPersona.Add(op7);

            return ListaPersona;
        }

        private void CargarReporte()
        {   //le paso el metodo donde se cargan las listas
            this.reportViewer1.LocalReport.DataSources[0].Value = CargarPersonas();
            this.reportViewer1.RefreshReport();

        }
    }
}
