using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Presentacion
{
    public partial class FrmCrearDS : Form
    {
        public FrmCrearDS()
        {
            InitializeComponent();
        }

        Metodos oBLL = new BLL.Metodos();
       
        public DataSet Dset = new DataSet();

        private void FrmCrearDS_Load(object sender, EventArgs e)
        {
            BtnCargarDs.Enabled = false;
            BtnMostrarDs.Enabled = false;
            this.groupBoxFiltros.Enabled = false;
        }

        private void BtnCrearDs_Click(object sender, EventArgs e)
        {
            Dset = oBLL.ArmarDataSet();
            BtnCargarDs.Enabled = true;
        }

        private void BtnCargarDs_Click(object sender, EventArgs e)
        {
                  //Le paso el dataset a cargar
            oBLL.CargarDs(Dset);
            BtnMostrarDs.Enabled = true;

        }

        private void BtnMostrarDs_Click(object sender, EventArgs e)
        {
            grdPersonas.DataSource = null;
            grdPersonas.DataSource = Dset;
            grdPersonas.DataMember = "Persona";
            //propiedad de la grilla para autosize de columnas
            this.grdPersonas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //cambio color alternando las filas de la grilla
            this.grdPersonas.AlternatingRowsDefaultCellStyle.BackColor = Color.DarkOrange;

            grdPaises.DataSource = null;
            grdPaises.DataSource = Dset.Tables["Pais"];
            // grdPaises.DataSource = Dset;
            // grdPaises.DataMember = "Pais";
            //propiedad de la grilla para autosize de columnas
            this.grdPaises.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //cambio color alternando las filas de la grilla
            this.grdPaises.AlternatingRowsDefaultCellStyle.BackColor = Color.Orange;

            //una vez que muestro los datos habilito los filtros
            this.groupBoxFiltros.Enabled = true;
       
        }

    

        private void btn_filtro_dataview_Click(object sender, EventArgs e)
        {

            try
            {   //cargo la tabla teporal
                DataTable TablaTemporal = Dset.Tables["Persona"];
                DataView dv = new DataView(TablaTemporal);


                if ((rdbPais.Checked) && (TxfiltroData.Text != string.Empty))
                {

                    //rowfilter es el filtro que se quiere realizar
                    dv.RowFilter = "Persona_Pais_Id =" + this.TxfiltroData.Text.Trim();

                    //el campo por el que quiero ordenar
                    dv.Sort = "FechaNac";

                    //como estoy en memoria limpio las columnas, sino aparecen 2 grillas
                    this.dataGridfiltros.Columns.Clear();
                    this.dataGridfiltros.DataSource = null;
                    this.dataGridfiltros.DataSource = dv;

                    this.dataGridfiltros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    //cambio color alternando las filas de la grilla
                    this.dataGridfiltros.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGreen;




                }
                else if ((rdbApe.Checked) && (TxfiltroData.Text != string.Empty))

                {
                    //rowfilter es el filtro que se quiere realizar
                   // dv.RowFilter = String.Format("Apellido = '{0}'" , this.TxfiltroData.Text.Trim());

                    dv.RowFilter = "Apellido = '" + this.TxfiltroData.Text.Trim() + "'";

                    //el campo por el que quiero ordenar
                    dv.Sort = "FechaNac";

                    //como estoy en memoria limpio las columnas, sino aparecen 2 grillas
                   this.dataGridfiltros.Columns.Clear();
                    this.dataGridfiltros.DataSource = null;
                    this.dataGridfiltros.DataSource = dv;

                    this.dataGridfiltros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    //cambio color alternando las filas de la grilla
                    this.dataGridfiltros.AlternatingRowsDefaultCellStyle.BackColor = Color.Yellow;

                }

                else
                { MessageBox.Show("Debe seleccionar una opcion y llenar el campo de busqueda"); }
             }
             catch (Exception ex)
             { MessageBox.Show(ex.Message); }

        }

        private void btn_FiltroDatatable_Click(object sender, EventArgs e)
        {
            try
            {

                if ((txtInicio.Text== string.Empty )|| (txtFin.Text == string.Empty))
                { MessageBox.Show("Debe ingresar las fechas para la busqueda"); }
                else
                { 
                DataTable TablaTmp = Dset.Tables["Persona"];
                string Filtro = null;
                Filtro = "FechaNac >=#1/1/" + this.txtInicio.Text.Trim() + "# and FechaNac <=#12/31/" + this.txtFin.Text.Trim() + "#";

                //borro todas las columnas de la grilla
                this.dataGridfiltros.Columns.Clear();

                //this.dataGridfiltros.Columns.Add("Nombre de la columna, y el encabezado de la columna");
                this.dataGridfiltros.Columns.Add("Codigo_Persona", "Codigo_Persona");
                this.dataGridfiltros.Columns.Add("Nombre", "Nombre");
                this.dataGridfiltros.Columns.Add("Apellido", "Apellido");
                this.dataGridfiltros.Columns.Add("FechaNac", "FechaNac");
                this.dataGridfiltros.Columns.Add("Persona_Pais_Id", "Persona_Pais_Id");
                    this.dataGridfiltros.DataSource = null;
                //se pasa el Filtro y puedo agregar xq columna se quiere ordenar
                foreach (DataRow fila in TablaTmp.Select(Filtro, "FechaNac"))

                  {
                    this.dataGridfiltros.Rows.Add(fila["Codigo_Persona"], fila["Apellido"], fila["Nombre"], Convert.ToDateTime( fila["FechaNac"]).ToShortDateString(), fila["Persona_Pais_Id"]);
               
                    }
                    this.dataGridfiltros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    //cambio color alternando las filas de la grilla
                    this.dataGridfiltros.AlternatingRowsDefaultCellStyle.BackColor = Color.Aquamarine;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtFin.Text = string.Empty;
            this.txtInicio.Text = string.Empty;
            this.TxfiltroData.Text = string.Empty;
            this.rdbApe.Checked = false;
            this.rdbPais.Checked = false;

            //como estoy en memoria, debo borrar la grilla completa sino quedan las columnas 

            this.dataGridfiltros.Columns.Clear();
        }
    }
}
