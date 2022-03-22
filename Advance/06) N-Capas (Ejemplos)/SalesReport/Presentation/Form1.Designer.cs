﻿namespace Presentation
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
            this.netSalesByPeriodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesListingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.ThisYearButton = new System.Windows.Forms.Button();
            this.Last30daysButton = new System.Windows.Forms.Button();
            this.ThisMonthButton = new System.Windows.Forms.Button();
            this.Last7daysButton = new System.Windows.Forms.Button();
            this.TodayButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.netSalesByPeriodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesListingBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.netSalesByPeriodBindingSource, "period", true));
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Right;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Presentation.Reports.SalesReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(170, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(630, 352);
            this.reportViewer1.TabIndex = 0;
            // 
            // netSalesByPeriodBindingSource
            // 
            this.netSalesByPeriodBindingSource.DataSource = typeof(Domain.NetSalesByPeriod);
            // 
            // salesReportBindingSource
            // 
            this.salesReportBindingSource.DataSource = typeof(Domain.SalesReport);
            // 
            // salesListingBindingSource
            // 
            this.salesListingBindingSource.DataSource = typeof(Domain.SalesListing);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "To";
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
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(42, 45);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(80, 20);
            this.dtpTo.TabIndex = 7;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(42, 19);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(80, 20);
            this.dtpFrom.TabIndex = 6;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 352);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewer1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.netSalesByPeriodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesListingBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource netSalesByPeriodBindingSource;
        private System.Windows.Forms.BindingSource salesReportBindingSource;
        private System.Windows.Forms.BindingSource salesListingBindingSource;
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
    }
}

