using System;
using System.Windows.Forms;
using Capa_de_Dominio;

namespace Capa_de_Presentación
{
    public partial class ReporteForm : Form
    {
        public ReporteForm() => InitializeComponent();
        private void ReporteForm_Load(object sender, EventArgs e) => HoyButton_Click(this, EventArgs.Empty);

        private void ObtenerReporteDeVentas(DateTime desde, DateTime hasta)
        {
            ReporteDeVentas modelo_de_reporte = new ReporteDeVentas();
            modelo_de_reporte.CrearReporteDeÓrdenesDeVentas(desde, hasta);

            reporteDeVentasBindingSource.DataSource = modelo_de_reporte;
            listadoDeVentasBindingSource.DataSource = modelo_de_reporte.listado_de_ventas;
            ventasNetasPorPeríodoBindingSource.DataSource = modelo_de_reporte.ventas_netas_por_periodo;

            this.ReportViewer.RefreshReport();
        }

        private void HoyButton_Click(object sender, EventArgs e)
        {
            var desde = DateTime.Today;
            var hasta = DateTime.Now;
            ObtenerReporteDeVentas(desde, hasta);
        }

        private void Últimos7díasButton_Click(object sender, EventArgs e)
        {
            var desde = DateTime.Today.AddDays(-7);
            var hasta = DateTime.Now;
            ObtenerReporteDeVentas(desde, hasta);
        }

        private void EsteMesButton_Click(object sender, EventArgs e)
        {
            var desde = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var hasta = DateTime.Now;
            ObtenerReporteDeVentas(desde, hasta);
        }

        private void Últimos30díasButton_Click(object sender, EventArgs e)
        {
            var desde = DateTime.Today.AddDays(-30);
            var hasta = DateTime.Now;
            ObtenerReporteDeVentas(desde, hasta);
        }

        private void EsteAñoButton_Click(object sender, EventArgs e)
        {
            var desde = new DateTime(DateTime.Now.Year, 1, 1);
            var hasta = DateTime.Now;
            ObtenerReporteDeVentas(desde, hasta);
        }

        private void RangoPersonalizadoButton_Click(object sender, EventArgs e)
        {
            var desde = DesdeDateTimePicker.Value;
            var hasta = HastaDateTimePicker.Value;
            ObtenerReporteDeVentas(desde, new DateTime(hasta.Year, hasta.Month, hasta.Day, 23, 59, 59));
        }
    }
}
