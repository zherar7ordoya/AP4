
namespace RebootReportes
{
    partial class GraficoFormulario
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
            this.UnicoChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.UnicoChart)).BeginInit();
            this.SuspendLayout();
            // 
            // UnicoChart
            // 
            chartArea1.Name = "ChartArea1";
            this.UnicoChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.UnicoChart.Legends.Add(legend1);
            this.UnicoChart.Location = new System.Drawing.Point(13, 13);
            this.UnicoChart.Name = "UnicoChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.UnicoChart.Series.Add(series1);
            this.UnicoChart.Size = new System.Drawing.Size(530, 300);
            this.UnicoChart.TabIndex = 0;
            this.UnicoChart.Text = "chart1";
            // 
            // GraficoFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 323);
            this.Controls.Add(this.UnicoChart);
            this.Name = "GraficoFormulario";
            this.Text = "GraficoFormulario";
            this.Load += new System.EventHandler(this.GraficoFormulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UnicoChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart UnicoChart;
    }
}