
namespace Capa_de_Presentación
{
    partial class ReporteDeVentas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.listadoDeVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reporteDeVentasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasNetasPorPeríodoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastaLabel = new System.Windows.Forms.Label();
            this.DesdeLabel = new System.Windows.Forms.Label();
            this.RangoPersonalizadoButton = new System.Windows.Forms.Button();
            this.EsteAñoButton = new System.Windows.Forms.Button();
            this.Últimos30díasButton = new System.Windows.Forms.Button();
            this.EsteMesButton = new System.Windows.Forms.Button();
            this.Últimos7díasButton = new System.Windows.Forms.Button();
            this.HoyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDeVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDeVentasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasNetasPorPeríodoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listadoDeVentasBindingSource
            // 
            this.listadoDeVentasBindingSource.DataSource = typeof(Capa_de_Dominio.ListadoDeVentas);
            // 
            // reporteDeVentasBindingSource
            // 
            this.reporteDeVentasBindingSource.DataSource = typeof(Capa_de_Dominio.ReporteDeVentas);
            // 
            // ventasNetasPorPeríodoBindingSource
            // 
            this.ventasNetasPorPeríodoBindingSource.DataSource = typeof(Capa_de_Dominio.VentasNetasPorPeríodo);
            // 
            // ReportViewer
            // 
            this.ReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "listadoDeVentas";
            reportDataSource1.Value = this.listadoDeVentasBindingSource;
            reportDataSource2.Name = "reporteDeVentas";
            reportDataSource2.Value = this.reporteDeVentasBindingSource;
            reportDataSource3.Name = "ventasNetasPorPeriodo";
            reportDataSource3.Value = this.ventasNetasPorPeríodoBindingSource;
            this.ReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.ReportViewer.LocalReport.DataSources.Add(reportDataSource3);
            this.ReportViewer.LocalReport.ReportEmbeddedResource = "Capa_de_Presentación.Reportes.ReporteDeVentas.rdlc";
            this.ReportViewer.Location = new System.Drawing.Point(147, 0);
            this.ReportViewer.Name = "ReportViewer";
            this.ReportViewer.ServerReport.BearerToken = null;
            this.ReportViewer.Size = new System.Drawing.Size(747, 416);
            this.ReportViewer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.HastaDateTimePicker);
            this.panel1.Controls.Add(this.DesdeDateTimePicker);
            this.panel1.Controls.Add(this.HastaLabel);
            this.panel1.Controls.Add(this.DesdeLabel);
            this.panel1.Controls.Add(this.RangoPersonalizadoButton);
            this.panel1.Controls.Add(this.EsteAñoButton);
            this.panel1.Controls.Add(this.Últimos30díasButton);
            this.panel1.Controls.Add(this.EsteMesButton);
            this.panel1.Controls.Add(this.Últimos7díasButton);
            this.panel1.Controls.Add(this.HoyButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 416);
            this.panel1.TabIndex = 1;
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastaDateTimePicker.Location = new System.Drawing.Point(15, 243);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.HastaDateTimePicker.TabIndex = 9;
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(15, 192);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.DesdeDateTimePicker.TabIndex = 8;
            // 
            // HastaLabel
            // 
            this.HastaLabel.Location = new System.Drawing.Point(12, 215);
            this.HastaLabel.Name = "HastaLabel";
            this.HastaLabel.Size = new System.Drawing.Size(120, 25);
            this.HastaLabel.TabIndex = 7;
            this.HastaLabel.Text = "Hasta";
            this.HastaLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // DesdeLabel
            // 
            this.DesdeLabel.Location = new System.Drawing.Point(12, 164);
            this.DesdeLabel.Name = "DesdeLabel";
            this.DesdeLabel.Size = new System.Drawing.Size(120, 25);
            this.DesdeLabel.TabIndex = 6;
            this.DesdeLabel.Text = "Desde";
            this.DesdeLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // RangoPersonalizadoButton
            // 
            this.RangoPersonalizadoButton.Location = new System.Drawing.Point(15, 269);
            this.RangoPersonalizadoButton.Name = "RangoPersonalizadoButton";
            this.RangoPersonalizadoButton.Size = new System.Drawing.Size(120, 25);
            this.RangoPersonalizadoButton.TabIndex = 5;
            this.RangoPersonalizadoButton.Text = "Rango personalizado";
            this.RangoPersonalizadoButton.UseVisualStyleBackColor = true;
            this.RangoPersonalizadoButton.Click += new System.EventHandler(this.RangoPersonalizadoButton_Click);
            // 
            // EsteAñoButton
            // 
            this.EsteAñoButton.Location = new System.Drawing.Point(12, 136);
            this.EsteAñoButton.Name = "EsteAñoButton";
            this.EsteAñoButton.Size = new System.Drawing.Size(120, 25);
            this.EsteAñoButton.TabIndex = 4;
            this.EsteAñoButton.Text = "Este año";
            this.EsteAñoButton.UseVisualStyleBackColor = true;
            this.EsteAñoButton.Click += new System.EventHandler(this.EsteAñoButton_Click);
            // 
            // Últimos30díasButton
            // 
            this.Últimos30díasButton.Location = new System.Drawing.Point(12, 105);
            this.Últimos30díasButton.Name = "Últimos30díasButton";
            this.Últimos30díasButton.Size = new System.Drawing.Size(120, 25);
            this.Últimos30díasButton.TabIndex = 3;
            this.Últimos30díasButton.Text = "Últimos 30 días";
            this.Últimos30díasButton.UseVisualStyleBackColor = true;
            this.Últimos30díasButton.Click += new System.EventHandler(this.Últimos30díasButton_Click);
            // 
            // EsteMesButton
            // 
            this.EsteMesButton.Location = new System.Drawing.Point(12, 74);
            this.EsteMesButton.Name = "EsteMesButton";
            this.EsteMesButton.Size = new System.Drawing.Size(120, 25);
            this.EsteMesButton.TabIndex = 2;
            this.EsteMesButton.Text = "Este mes";
            this.EsteMesButton.UseVisualStyleBackColor = true;
            this.EsteMesButton.Click += new System.EventHandler(this.EsteMesButton_Click);
            // 
            // Últimos7díasButton
            // 
            this.Últimos7díasButton.Location = new System.Drawing.Point(12, 43);
            this.Últimos7díasButton.Name = "Últimos7díasButton";
            this.Últimos7díasButton.Size = new System.Drawing.Size(120, 25);
            this.Últimos7díasButton.TabIndex = 1;
            this.Últimos7díasButton.Text = "Últimos 7 días";
            this.Últimos7díasButton.UseVisualStyleBackColor = true;
            this.Últimos7díasButton.Click += new System.EventHandler(this.Últimos7díasButton_Click);
            // 
            // HoyButton
            // 
            this.HoyButton.Location = new System.Drawing.Point(12, 12);
            this.HoyButton.Name = "HoyButton";
            this.HoyButton.Size = new System.Drawing.Size(120, 25);
            this.HoyButton.TabIndex = 0;
            this.HoyButton.Text = "Hoy";
            this.HoyButton.UseVisualStyleBackColor = true;
            this.HoyButton.Click += new System.EventHandler(this.HoyButton_Click);
            // 
            // ReporteDeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 416);
            this.Controls.Add(this.ReportViewer);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReporteDeVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Ventas";
            this.Load += new System.EventHandler(this.ReporteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadoDeVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteDeVentasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasNetasPorPeríodoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewer;
        private System.Windows.Forms.BindingSource ventasNetasPorPeríodoBindingSource;
        private System.Windows.Forms.BindingSource listadoDeVentasBindingSource;
        private System.Windows.Forms.BindingSource reporteDeVentasBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.Label HastaLabel;
        private System.Windows.Forms.Label DesdeLabel;
        private System.Windows.Forms.Button RangoPersonalizadoButton;
        private System.Windows.Forms.Button EsteAñoButton;
        private System.Windows.Forms.Button Últimos30díasButton;
        private System.Windows.Forms.Button EsteMesButton;
        private System.Windows.Forms.Button Últimos7díasButton;
        private System.Windows.Forms.Button HoyButton;
    }
}

