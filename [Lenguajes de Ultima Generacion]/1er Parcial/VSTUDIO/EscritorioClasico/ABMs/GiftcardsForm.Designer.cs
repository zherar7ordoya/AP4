namespace EscritorioClasico.ABMs
{
    partial class GiftcardsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.VistazoGroupBox = new System.Windows.Forms.GroupBox();
            this.MenorSaldoTextBox = new System.Windows.Forms.TextBox();
            this.MenorSaldoLabel = new System.Windows.Forms.Label();
            this.MayorDescuentoTextBox = new System.Windows.Forms.TextBox();
            this.MayorDescuentoLabel = new System.Windows.Forms.Label();
            this.GiftcardsDataGridView = new System.Windows.Forms.DataGridView();
            this.AltaGiftcardButton = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.VistazoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GiftcardsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // VistazoGroupBox
            // 
            this.VistazoGroupBox.Controls.Add(this.MenorSaldoTextBox);
            this.VistazoGroupBox.Controls.Add(this.MenorSaldoLabel);
            this.VistazoGroupBox.Controls.Add(this.MayorDescuentoTextBox);
            this.VistazoGroupBox.Controls.Add(this.MayorDescuentoLabel);
            this.VistazoGroupBox.Location = new System.Drawing.Point(12, 12);
            this.VistazoGroupBox.Name = "VistazoGroupBox";
            this.VistazoGroupBox.Size = new System.Drawing.Size(600, 80);
            this.VistazoGroupBox.TabIndex = 1;
            this.VistazoGroupBox.TabStop = false;
            this.VistazoGroupBox.Text = "Vistazo";
            // 
            // MenorSaldoTextBox
            // 
            this.MenorSaldoTextBox.Location = new System.Drawing.Point(312, 47);
            this.MenorSaldoTextBox.Name = "MenorSaldoTextBox";
            this.MenorSaldoTextBox.Size = new System.Drawing.Size(150, 20);
            this.MenorSaldoTextBox.TabIndex = 5;
            // 
            // MenorSaldoLabel
            // 
            this.MenorSaldoLabel.Location = new System.Drawing.Point(6, 42);
            this.MenorSaldoLabel.Name = "MenorSaldoLabel";
            this.MenorSaldoLabel.Size = new System.Drawing.Size(300, 25);
            this.MenorSaldoLabel.TabIndex = 4;
            this.MenorSaldoLabel.Text = "Gift Card con menor saldo";
            this.MenorSaldoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MayorDescuentoTextBox
            // 
            this.MayorDescuentoTextBox.Location = new System.Drawing.Point(312, 21);
            this.MayorDescuentoTextBox.Name = "MayorDescuentoTextBox";
            this.MayorDescuentoTextBox.Size = new System.Drawing.Size(150, 20);
            this.MayorDescuentoTextBox.TabIndex = 3;
            // 
            // MayorDescuentoLabel
            // 
            this.MayorDescuentoLabel.Location = new System.Drawing.Point(6, 16);
            this.MayorDescuentoLabel.Name = "MayorDescuentoLabel";
            this.MayorDescuentoLabel.Size = new System.Drawing.Size(300, 25);
            this.MayorDescuentoLabel.TabIndex = 2;
            this.MayorDescuentoLabel.Text = "Gift Card con mayor descuento";
            this.MayorDescuentoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GiftcardsDataGridView
            // 
            this.GiftcardsDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.GiftcardsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GiftcardsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.GiftcardsDataGridView.ColumnHeadersHeight = 25;
            this.GiftcardsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Borrar,
            this.Editar});
            this.GiftcardsDataGridView.Location = new System.Drawing.Point(12, 98);
            this.GiftcardsDataGridView.Name = "GiftcardsDataGridView";
            this.GiftcardsDataGridView.RowTemplate.Height = 32;
            this.GiftcardsDataGridView.Size = new System.Drawing.Size(600, 300);
            this.GiftcardsDataGridView.TabIndex = 3;
            this.GiftcardsDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GiftcardsDataGridView_CellContentDoubleClick);
            // 
            // AltaGiftcardButton
            // 
            this.AltaGiftcardButton.Location = new System.Drawing.Point(619, 375);
            this.AltaGiftcardButton.Name = "AltaGiftcardButton";
            this.AltaGiftcardButton.Size = new System.Drawing.Size(75, 23);
            this.AltaGiftcardButton.TabIndex = 2;
            this.AltaGiftcardButton.Text = "Alta";
            this.AltaGiftcardButton.UseVisualStyleBackColor = true;
            this.AltaGiftcardButton.Click += new System.EventHandler(this.AltaGitfcardButton_Click);
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Image = global::EscritorioClasico.Properties.Resources.Borrar32x32;
            this.Borrar.Name = "Borrar";
            this.Borrar.Width = 41;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::EscritorioClasico.Properties.Resources.Editar32x32;
            this.Editar.Name = "Editar";
            this.Editar.Width = 40;
            // 
            // GiftcardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 436);
            this.Controls.Add(this.GiftcardsDataGridView);
            this.Controls.Add(this.AltaGiftcardButton);
            this.Controls.Add(this.VistazoGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GiftcardsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gift Cards";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GiftcardsForm_FormClosing);
            this.Load += new System.EventHandler(this.GiftcardsForm_Load);
            this.VistazoGroupBox.ResumeLayout(false);
            this.VistazoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GiftcardsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox VistazoGroupBox;
        private System.Windows.Forms.TextBox MayorDescuentoTextBox;
        private System.Windows.Forms.Label MayorDescuentoLabel;
        private System.Windows.Forms.TextBox MenorSaldoTextBox;
        private System.Windows.Forms.Label MenorSaldoLabel;
        private System.Windows.Forms.DataGridView GiftcardsDataGridView;
        private System.Windows.Forms.Button AltaGiftcardButton;
        private System.Windows.Forms.DataGridViewImageColumn Borrar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
    }
}