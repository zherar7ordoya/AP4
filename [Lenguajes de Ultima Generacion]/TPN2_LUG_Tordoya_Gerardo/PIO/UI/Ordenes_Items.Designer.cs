
namespace UI
{
    partial class Ordenes_Items
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReporteListadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportePeriodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteListadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportePeriodoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource4.Name = "Reporte";
            reportDataSource4.Value = this.ReporteBindingSource;
            reportDataSource5.Name = "Listado";
            reportDataSource5.Value = this.ReporteListadoBindingSource;
            reportDataSource6.Name = "Periodo";
            reportDataSource6.Value = this.ReportePeriodoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Ordenes_Items.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(128, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(594, 437);
            this.reportViewer1.TabIndex = 0;
            // 
            // ReporteBindingSource
            // 
            this.ReporteBindingSource.DataSource = typeof(MAPEO.Reporte);
            // 
            // ReporteListadoBindingSource
            // 
            this.ReporteListadoBindingSource.DataSource = typeof(BE.ReporteListado);
            // 
            // ReportePeriodoBindingSource
            // 
            this.ReportePeriodoBindingSource.DataSource = typeof(BE.ReportePeriodo);
            // 
            // Ordenes_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Ordenes_Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.Load += new System.EventHandler(this.Ordenes_Items_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteListadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReportePeriodoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ReporteBindingSource;
        private System.Windows.Forms.BindingSource ReporteListadoBindingSource;
        private System.Windows.Forms.BindingSource ReportePeriodoBindingSource;
    }
}