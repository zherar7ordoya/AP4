
namespace UI
{
    partial class XML_Form
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
            this.HastaLabel = new System.Windows.Forms.Label();
            this.DesdeLabel = new System.Windows.Forms.Label();
            this.DesdeDTP = new System.Windows.Forms.DateTimePicker();
            this.HastaDTP = new System.Windows.Forms.DateTimePicker();
            this.EsteAñoButton = new System.Windows.Forms.Button();
            this.MostrarButton = new System.Windows.Forms.Button();
            this.UltimosTreintaButton = new System.Windows.Forms.Button();
            this.UltimosSieteButton = new System.Windows.Forms.Button();
            this.EsteMesButton = new System.Windows.Forms.Button();
            this.HoyButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // HastaLabel
            // 
            this.HastaLabel.Location = new System.Drawing.Point(652, 345);
            this.HastaLabel.Name = "HastaLabel";
            this.HastaLabel.Size = new System.Drawing.Size(100, 20);
            this.HastaLabel.TabIndex = 38;
            this.HastaLabel.Text = "Hasta";
            this.HastaLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // DesdeLabel
            // 
            this.DesdeLabel.Location = new System.Drawing.Point(652, 299);
            this.DesdeLabel.Name = "DesdeLabel";
            this.DesdeLabel.Size = new System.Drawing.Size(100, 20);
            this.DesdeLabel.TabIndex = 37;
            this.DesdeLabel.Text = "Desde";
            this.DesdeLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // DesdeDTP
            // 
            this.DesdeDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DesdeDTP.Location = new System.Drawing.Point(655, 322);
            this.DesdeDTP.Name = "DesdeDTP";
            this.DesdeDTP.Size = new System.Drawing.Size(100, 20);
            this.DesdeDTP.TabIndex = 33;
            // 
            // HastaDTP
            // 
            this.HastaDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.HastaDTP.Location = new System.Drawing.Point(655, 368);
            this.HastaDTP.Name = "HastaDTP";
            this.HastaDTP.Size = new System.Drawing.Size(100, 20);
            this.HastaDTP.TabIndex = 34;
            // 
            // EsteAñoButton
            // 
            this.EsteAñoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EsteAñoButton.Location = new System.Drawing.Point(655, 231);
            this.EsteAñoButton.Name = "EsteAñoButton";
            this.EsteAñoButton.Size = new System.Drawing.Size(100, 50);
            this.EsteAñoButton.TabIndex = 32;
            this.EsteAñoButton.Text = "Este año";
            this.EsteAñoButton.UseVisualStyleBackColor = true;
            // 
            // MostrarButton
            // 
            this.MostrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MostrarButton.Location = new System.Drawing.Point(655, 394);
            this.MostrarButton.Name = "MostrarButton";
            this.MostrarButton.Size = new System.Drawing.Size(100, 50);
            this.MostrarButton.TabIndex = 35;
            this.MostrarButton.Text = "Mostrar";
            this.MostrarButton.UseVisualStyleBackColor = true;
            this.MostrarButton.Click += new System.EventHandler(this.MostrarButton_Click);
            // 
            // UltimosTreintaButton
            // 
            this.UltimosTreintaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UltimosTreintaButton.Location = new System.Drawing.Point(655, 175);
            this.UltimosTreintaButton.Name = "UltimosTreintaButton";
            this.UltimosTreintaButton.Size = new System.Drawing.Size(100, 50);
            this.UltimosTreintaButton.TabIndex = 31;
            this.UltimosTreintaButton.Text = "Los últimos 30 días";
            this.UltimosTreintaButton.UseVisualStyleBackColor = true;
            // 
            // UltimosSieteButton
            // 
            this.UltimosSieteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UltimosSieteButton.Location = new System.Drawing.Point(655, 63);
            this.UltimosSieteButton.Name = "UltimosSieteButton";
            this.UltimosSieteButton.Size = new System.Drawing.Size(100, 50);
            this.UltimosSieteButton.TabIndex = 29;
            this.UltimosSieteButton.Text = "Los últimos 7 días";
            this.UltimosSieteButton.UseVisualStyleBackColor = true;
            // 
            // EsteMesButton
            // 
            this.EsteMesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EsteMesButton.Location = new System.Drawing.Point(655, 119);
            this.EsteMesButton.Name = "EsteMesButton";
            this.EsteMesButton.Size = new System.Drawing.Size(100, 50);
            this.EsteMesButton.TabIndex = 30;
            this.EsteMesButton.Text = "Este mes";
            this.EsteMesButton.UseVisualStyleBackColor = true;
            // 
            // HoyButton
            // 
            this.HoyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoyButton.Location = new System.Drawing.Point(655, 7);
            this.HoyButton.Name = "HoyButton";
            this.HoyButton.Size = new System.Drawing.Size(100, 50);
            this.HoyButton.TabIndex = 28;
            this.HoyButton.Text = "Hoy";
            this.HoyButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 437);
            this.dataGridView1.TabIndex = 39;
            // 
            // XML_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.HastaLabel);
            this.Controls.Add(this.DesdeLabel);
            this.Controls.Add(this.DesdeDTP);
            this.Controls.Add(this.HastaDTP);
            this.Controls.Add(this.EsteAñoButton);
            this.Controls.Add(this.MostrarButton);
            this.Controls.Add(this.UltimosTreintaButton);
            this.Controls.Add(this.UltimosSieteButton);
            this.Controls.Add(this.EsteMesButton);
            this.Controls.Add(this.HoyButton);
            this.Name = "XML_Form";
            this.Text = "XML_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HastaLabel;
        private System.Windows.Forms.Label DesdeLabel;
        private System.Windows.Forms.DateTimePicker DesdeDTP;
        private System.Windows.Forms.DateTimePicker HastaDTP;
        private System.Windows.Forms.Button EsteAñoButton;
        private System.Windows.Forms.Button MostrarButton;
        private System.Windows.Forms.Button UltimosTreintaButton;
        private System.Windows.Forms.Button UltimosSieteButton;
        private System.Windows.Forms.Button EsteMesButton;
        private System.Windows.Forms.Button HoyButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}