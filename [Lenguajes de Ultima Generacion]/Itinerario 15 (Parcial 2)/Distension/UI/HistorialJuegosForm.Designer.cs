﻿
namespace UI
{
    partial class HistorialJuegosForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BarrasChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.BarrasChart)).BeginInit();
            this.SuspendLayout();
            // 
            // BarrasChart
            // 
            chartArea1.Name = "ChartArea1";
            this.BarrasChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BarrasChart.Legends.Add(legend1);
            this.BarrasChart.Location = new System.Drawing.Point(12, 12);
            this.BarrasChart.Name = "BarrasChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.BarrasChart.Series.Add(series1);
            this.BarrasChart.Size = new System.Drawing.Size(351, 337);
            this.BarrasChart.TabIndex = 0;
            this.BarrasChart.Text = "chart1";
            // 
            // HistorialJuegosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.BarrasChart);
            this.Name = "HistorialJuegosForm";
            this.Text = "Historial Juegos";
            this.Load += new System.EventHandler(this.JuegosReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BarrasChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BarrasChart;
    }
}