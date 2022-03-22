namespace Presentation
{
    partial class Form1
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.salesReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesListingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.netSalesByPeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.salesReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesListingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.netSalesByPeriodBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.netSalesByPeriodBindingSource, "period", true));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentation.Reports.SalesReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(38, 26);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // salesReportBindingSource
            // 
            this.salesReportBindingSource.DataSource = typeof(Domain.SalesReport);
            // 
            // salesListingBindingSource
            // 
            this.salesListingBindingSource.DataSource = typeof(Domain.SalesListing);
            // 
            // netSalesByPeriodBindingSource
            // 
            this.netSalesByPeriodBindingSource.DataSource = typeof(Domain.NetSalesByPeriod);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesListingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.netSalesByPeriodBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource netSalesByPeriodBindingSource;
        private System.Windows.Forms.BindingSource salesReportBindingSource;
        private System.Windows.Forms.BindingSource salesListingBindingSource;
    }
}

