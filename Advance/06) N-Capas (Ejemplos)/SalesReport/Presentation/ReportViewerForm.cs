using System;
using System.Windows.Forms;
using Domain;

namespace Presentation
{
    public partial class ReportViewerForm : Form
    {
        public ReportViewerForm() { InitializeComponent(); }
        private void ReportViewerForm_Load(object sender, EventArgs e) { TodayButton_Click(this, EventArgs.Empty); }

        private void GetSalesReport(DateTime startDate, DateTime endDAte)
        {
            SalesReport reportModel = new SalesReport();
            reportModel.CreateSalesOrderReport(startDate, endDAte);

            SalesReportBindingSource.DataSource = reportModel;
            SalesListingBindingSource.DataSource = reportModel.salesListing;
            NetSalesByPeriodBindingSource.DataSource = reportModel.netSalesByPeriod;

            this.reportViewer1.RefreshReport();
        }

        private void TodayButton_Click(object sender, EventArgs e)
        {
            /* EXPLICACIÓN (LÉASE, MUY INTERESANTE)
             * 
             * Cuando trabajamos con fechas, es importante tener en cuenta las
             * horas. En nuestro caso:
             *      -) TODAY obtiene 03-Nov-2019-00:00 (AM)
             *      -) NOW   obtiene 03-Nov-2019-12:11 (PM)
             * Al usarlo así, de esta manera, obtendremos el reporte de ventas
             * de las últimas 12 horas con 11 minutos.
             * Es decir, cumple las expectativas.
             */
            var fromDate = DateTime.Today;
            var toDate = DateTime.Now;
            GetSalesReport(fromDate, toDate);
        }

        private void Last7daysButton_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-7);
            var toDate = DateTime.Now;
            GetSalesReport(fromDate, toDate);
        }

        private void ThisMonthButton_Click(object sender, EventArgs e)
        {
            /* Ver la nota con respecto a las horas. En este caso, al crear una
             * instancia de DateTime, si no se especifica la hora, por defecto
             * es 00:00.
             */
            var fromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var toDate = DateTime.Now;
            GetSalesReport(fromDate, toDate);
        }

        private void Last30daysButton_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-30);
            var toDate = DateTime.Now;
            GetSalesReport(fromDate, toDate);
        }

        private void ThisYearButton_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(DateTime.Now.Year, 1, 1);
            var toDate = DateTime.Now;
            GetSalesReport(fromDate, toDate);
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            var fromDate = dtpFrom.Value;
            var toDate = dtpTo.Value;
            /* Es necesario modificar la fecha final ya que no cubre hasta la
             * hora final (23:59:59) pues por defecto Value tomará 00:00:00 por
             * defecto. Es decir, el default es el primer y no el último
             * instante del día.
             */
            GetSalesReport(fromDate, new DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 59));
        }
    }
}
