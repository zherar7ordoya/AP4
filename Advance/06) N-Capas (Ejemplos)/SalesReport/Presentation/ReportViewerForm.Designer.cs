namespace Presentation
{
    partial class ReportViewerForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.SalesReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesListingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NetSalesByPeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.ThisYearButton = new System.Windows.Forms.Button();
            this.Last30daysButton = new System.Windows.Forms.Button();
            this.ThisMonthButton = new System.Windows.Forms.Button();
            this.Last7daysButton = new System.Windows.Forms.Button();
            this.TodayButton = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesListingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetSalesByPeriodBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalesReportBindingSource
            // 
            this.SalesReportBindingSource.DataSource = typeof(Domain.SalesReport);
            // 
            // SalesListingBindingSource
            // 
            this.SalesListingBindingSource.DataSource = typeof(Domain.SalesListing);
            // 
            // NetSalesByPeriodBindingSource
            // 
            this.NetSalesByPeriodBindingSource.DataSource = typeof(Domain.NetSalesByPeriod);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.ThisYearButton);
            this.panel1.Controls.Add(this.Last30daysButton);
            this.panel1.Controls.Add(this.ThisMonthButton);
            this.panel1.Controls.Add(this.Last7daysButton);
            this.panel1.Controls.Add(this.TodayButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 352);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ApplyButton);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Location = new System.Drawing.Point(12, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 104);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Custom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "From";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(42, 71);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(80, 23);
            this.ApplyButton.TabIndex = 10;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(42, 19);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(80, 20);
            this.dtpFrom.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "To";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(42, 45);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(80, 20);
            this.dtpTo.TabIndex = 7;
            // 
            // ThisYearButton
            // 
            this.ThisYearButton.Location = new System.Drawing.Point(54, 128);
            this.ThisYearButton.Name = "ThisYearButton";
            this.ThisYearButton.Size = new System.Drawing.Size(75, 23);
            this.ThisYearButton.TabIndex = 4;
            this.ThisYearButton.Text = "This year";
            this.ThisYearButton.UseVisualStyleBackColor = true;
            this.ThisYearButton.Click += new System.EventHandler(this.ThisYearButton_Click);
            // 
            // Last30daysButton
            // 
            this.Last30daysButton.Location = new System.Drawing.Point(54, 99);
            this.Last30daysButton.Name = "Last30daysButton";
            this.Last30daysButton.Size = new System.Drawing.Size(75, 23);
            this.Last30daysButton.TabIndex = 3;
            this.Last30daysButton.Text = "Last 30 days";
            this.Last30daysButton.UseVisualStyleBackColor = true;
            this.Last30daysButton.Click += new System.EventHandler(this.Last30daysButton_Click);
            // 
            // ThisMonthButton
            // 
            this.ThisMonthButton.Location = new System.Drawing.Point(54, 70);
            this.ThisMonthButton.Name = "ThisMonthButton";
            this.ThisMonthButton.Size = new System.Drawing.Size(75, 23);
            this.ThisMonthButton.TabIndex = 2;
            this.ThisMonthButton.Text = "This month";
            this.ThisMonthButton.UseVisualStyleBackColor = true;
            this.ThisMonthButton.Click += new System.EventHandler(this.ThisMonthButton_Click);
            // 
            // Last7daysButton
            // 
            this.Last7daysButton.Location = new System.Drawing.Point(54, 41);
            this.Last7daysButton.Name = "Last7daysButton";
            this.Last7daysButton.Size = new System.Drawing.Size(75, 23);
            this.Last7daysButton.TabIndex = 1;
            this.Last7daysButton.Text = "Last 7 days";
            this.Last7daysButton.UseVisualStyleBackColor = true;
            this.Last7daysButton.Click += new System.EventHandler(this.Last7daysButton_Click);
            // 
            // TodayButton
            // 
            this.TodayButton.Location = new System.Drawing.Point(54, 12);
            this.TodayButton.Name = "TodayButton";
            this.TodayButton.Size = new System.Drawing.Size(75, 23);
            this.TodayButton.TabIndex = 0;
            this.TodayButton.Text = "Today";
            this.TodayButton.UseVisualStyleBackColor = true;
            this.TodayButton.Click += new System.EventHandler(this.TodayButton_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource7.Name = "salesReport";
            reportDataSource7.Value = this.SalesReportBindingSource;
            reportDataSource8.Name = "salesListing";
            reportDataSource8.Value = this.SalesListingBindingSource;
            reportDataSource9.Name = "netSalesByPeriod";
            reportDataSource9.Value = this.NetSalesByPeriodBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentation.Reports.SalesReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(164, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(636, 352);
            this.reportViewer1.TabIndex = 5;
            // 
            // ReportViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 352);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportViewerForm";
            this.Text = "Report Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportViewerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesListingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetSalesByPeriodBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button ThisYearButton;
        private System.Windows.Forms.Button Last30daysButton;
        private System.Windows.Forms.Button ThisMonthButton;
        private System.Windows.Forms.Button Last7daysButton;
        private System.Windows.Forms.Button TodayButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SalesReportBindingSource;
        private System.Windows.Forms.BindingSource SalesListingBindingSource;
        private System.Windows.Forms.BindingSource NetSalesByPeriodBindingSource;
    }
}

