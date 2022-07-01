using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Ordenes_Items : Form
    {
        public Ordenes_Items()
        {
            InitializeComponent();
        }

        private void Ordenes_Items_Load(object sender, EventArgs e)
        {
            var desde = new DateTime(DateTime.Now.Year, 1, 1);
            var hasta = DateTime.Now;
            CargarReporte(desde, hasta);
            
        }


        private void CargarReporte(DateTime desde, DateTime hasta)
        {
            MAPEO.Reporte modelo_de_reporte = new MAPEO.Reporte();
            modelo_de_reporte.MapearReporte(desde, hasta);

            ReporteBindingSource.DataSource = modelo_de_reporte;
            ReporteListadoBindingSource.DataSource = modelo_de_reporte.REPORTE_LISTADO;
            ReportePeriodoBindingSource.DataSource = modelo_de_reporte.REPORTE_PERIODO;

            this.reportViewer1.RefreshReport();
        }


    }
}
