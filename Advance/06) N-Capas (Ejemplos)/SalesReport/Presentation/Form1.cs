using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();
        private void Form1_Load(object sender, EventArgs e) { }

        private void GetSalesReport(DateTime startDate, DateTime endDAte)
        {
            SalesReport reportModel = new SalesReport();
            reportModel.CreateSalesOrderReport(startDate, endDAte);

            salesReportBindingSource.DataSource = reportModel;
            salesListingBindingSource.DataSource = reportModel.salesListing;
            netSalesByPeriodBindingSource.DataSource = reportModel.netSalesByPeriod;

            this.reportViewer1.RefreshReport();

            //36:18

        }
    }
}
