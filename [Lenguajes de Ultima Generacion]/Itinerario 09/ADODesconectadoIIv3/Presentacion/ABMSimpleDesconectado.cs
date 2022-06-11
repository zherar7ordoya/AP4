using System;
using System.Data;
using System.Windows.Forms;
using BLL;


namespace Presentacion
{
    public partial class ABMSimpleDesconectado : Form
    {
        public ABMSimpleDesconectado()
        {
            InitializeComponent();
        }

        Metodos OBLL = new BLL.Metodos();
        ClsPersona OPersona = new BLL.ClsPersona();
        ClsAuto oAuto = new BLL.ClsAuto();
        DataSet Dset = new DataSet();

        //CON SOLO CAMBIAR ESTA CONSTANTE SE ADMINISTRA OTRA TABLA
        const string NombreTabla = "Persona";
        //const string  NombreTabla = "Auto"

        private void ABMSimpleDesconectado_Load(object sender, EventArgs e)
        {
         
        }

        void Cargargrilla(String NombreTabla)
        {
            if (NombreTabla == "Persona")
            { Dset = OPersona.Listar();
                //Cargo con la Tabla 
                mGrilla.DataSource = null;
                mGrilla.DataSource = Dset.Tables[0];
                mGrilla.Columns[4].DefaultCellStyle.Format = "C";
            }
            else if (NombreTabla == "Auto")
            { Dset = oAuto.Listar();
                //Cargo con la Tabla 
                mGrilla.DataSource = null;
                mGrilla.DataSource = Dset.Tables[0];
            }
            else
            { Dset = null; }

            
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            OBLL.DescartarCambios(Dset);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Cargargrilla(CargarTabla());
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (rdbPersona.Checked)
            {
                OBLL.GrabarCambios("Persona", Dset);
                Cargargrilla("Persona");

            }
            else
            {
                OBLL.GrabarCambios("Auto", Dset);
                Cargargrilla("Auto");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Cargargrilla(CargarTabla());


        }

        string CargarTabla()
        {
           
            if (rdbPersona.Checked)
            { return "Persona"; }

            else if (rdbAuto.Checked)
            { return "Auto"; }

            else
            { MessageBox.Show("Seleccione una tabla"); }

            return null;
        }

        private void ABMSimpleDesconectado_FormClosing(object sender, FormClosingEventArgs e)
        {
            MENU.formulario_ABMSimpleDesconectado = false;
        }
    }
}
