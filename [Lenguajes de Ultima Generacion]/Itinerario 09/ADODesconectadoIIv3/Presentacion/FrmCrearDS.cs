using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BLL;

namespace Presentacion
{
    public partial class FrmCrearDS : Form
    {
        public FrmCrearDS() => InitializeComponent();

        Metodos oBLL = new Metodos();
        public DataSet dataset = new DataSet();

        private void FrmCrearDS_Load(object sender, EventArgs e)
        {
            BtnCargarDs.Enabled = false;
            BtnMostrarDs.Enabled = false;
            this.groupBoxFiltros.Enabled = false;
        }

        private void BtnCrearDs_Click(object sender, EventArgs e)
        {
            dataset = oBLL.ArmarDataSet();
            BtnCargarDs.Enabled = true;
        }

        private void BtnCargarDs_Click(object sender, EventArgs e)
        {
            //LE PASO EL DATASET A CARGAR.
            oBLL.CargarDataSet(dataset);
            BtnMostrarDs.Enabled = true;
        }

        private void BtnMostrarDs_Click(object sender, EventArgs e)
        {
            //1RA FORMA DE CARGAR.
            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = dataset;
            dgvPersonas.DataMember = "Persona";

            //2DA FORMA DE CARGAR.
            dgvPaises.DataSource = null;
            dgvPaises.DataSource = dataset.Tables["Pais"];

            //HABILITAR FILTROS.
            this.groupBoxFiltros.Enabled = true;
        }


        // *-------------------------------------------------------=> 2DA PARTE


        private void FiltrarDataTable_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                if ((txtInicio.Text == string.Empty) || (txtFin.Text == string.Empty))
                { MessageBox.Show("Debe ingresar las fechas para la busqueda"); }
                else
                {
                    DataTable datatable = dataset.Tables["Persona"];
                    string Filtro = null;
                    Filtro =
                        "FechaNac >= #1/1/" + 
                        this.txtInicio.Text.Trim() + 
                        "# AND FechaNac <= #12/31/" + 
                        this.txtFin.Text.Trim() + 
                        "#";

                    //LIMPIO GRILLA
                    this.dgvFiltros.Columns.Clear();

                    //this.DGV.Columns.Add(nombre_columna, encabezado_columna);
                    this.dgvFiltros.Columns.Add("Codigo_Persona", "Codigo_Persona");
                    this.dgvFiltros.Columns.Add("Nombre", "Nombre");
                    this.dgvFiltros.Columns.Add("Apellido", "Apellido");
                    this.dgvFiltros.Columns.Add("FechaNac", "FechaNac");
                    this.dgvFiltros.Columns.Add("Persona_Pais_Id", "Persona_Pais_Id");
                    this.dgvFiltros.DataSource = null;

                    //FILTRADO ( SE PUEDE AGREGAR COLUMNA DE ORDEN)
                    foreach (DataRow fila in datatable.Select(Filtro, "FechaNac"))
                    {
                        this.dgvFiltros.Rows.Add(
                            fila["Codigo_Persona"], 
                            fila["Apellido"], 
                            fila["Nombre"], 
                            Convert.ToDateTime(fila["FechaNac"]).ToShortDateString(), 
                            fila["Persona_Pais_Id"]);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }





        private void FiltrarDataView_ButtonClick(object sender, EventArgs e)
        {
            try
            {   //CREAR Y CARGAR UNA TABLA  Y VISTA TEMPORALES.
                DataTable datatable = dataset.Tables["Persona"];
                DataView dataview = new DataView(datatable);

                if ((rdbPais.Checked) && (TxfiltroData.Text != string.Empty))
                {
                    //ROWFILTER ES EL FILTRO.
                    dataview.RowFilter = "Persona_Pais_Id = " + this.TxfiltroData.Text.Trim();

                    //ESPECIFICAR LA COLUMNA QUE QUIERO ORDENAR.
                    dataview.Sort = "FechaNac";

                    //LIMPIAR (MEMORIA Y CONTROL) Y CARGAR NUEVA DATA.
                    this.dgvFiltros.Columns.Clear();
                    this.dgvFiltros.DataSource = null;
                    this.dgvFiltros.DataSource = dataview;
                }
                else if ((rdbApe.Checked) && (TxfiltroData.Text != string.Empty))
                {
                    dataview.RowFilter = "Apellido = '" + this.TxfiltroData.Text.Trim() + "'";
                    dataview.Sort = "FechaNac";

                    this.dgvFiltros.Columns.Clear();
                    this.dgvFiltros.DataSource = null;
                    this.dgvFiltros.DataSource = dataview;
                }
                else { MessageBox.Show("Debe seleccionar una opción y llenar el campo de búsqueda."); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private void LimpiarFiltro_ButtonClick(object sender, EventArgs e)
        {
            this.txtFin.Text = string.Empty;
            this.txtInicio.Text = string.Empty;
            this.TxfiltroData.Text = string.Empty;
            this.rdbApe.Checked = false;
            this.rdbPais.Checked = false;

            //COMO ESTOY EN MEMORIA, DEBO BORRAR LA GRILLA COMPLETA SINO QUEDAN
            //LAS COLUMNAS.
            this.dgvFiltros.Columns.Clear();
        }

        private void FrmCrearDS_FormClosing(object sender, FormClosingEventArgs e)
        {
            MENU.formulario_FrmCrearDS = false;
        }
    }
}
