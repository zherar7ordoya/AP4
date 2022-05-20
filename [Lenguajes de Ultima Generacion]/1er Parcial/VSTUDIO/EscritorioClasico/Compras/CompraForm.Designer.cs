namespace EscritorioClasico.Compras
{
    partial class CompraForm
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
            this.DescuentoCalculadoTextBox = new System.Windows.Forms.TextBox();
            this.ImporteCompraTextBox = new System.Windows.Forms.TextBox();
            this.TipoTextBox = new System.Windows.Forms.TextBox();
            this.DescuentoCalculadoLabel = new System.Windows.Forms.Label();
            this.ImporteCompraLabel = new System.Windows.Forms.Label();
            this.SaldoTextBox = new System.Windows.Forms.TextBox();
            this.SaldoLabel = new System.Windows.Forms.Label();
            this.TipoLabel = new System.Windows.Forms.Label();
            this.GiftcardTextBox = new System.Windows.Forms.TextBox();
            this.GiftcardLabel = new System.Windows.Forms.Label();
            this.RegistrarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DescuentoCalculadoTextBox
            // 
            this.DescuentoCalculadoTextBox.Location = new System.Drawing.Point(168, 118);
            this.DescuentoCalculadoTextBox.Name = "DescuentoCalculadoTextBox";
            this.DescuentoCalculadoTextBox.Size = new System.Drawing.Size(150, 20);
            this.DescuentoCalculadoTextBox.TabIndex = 68;
            // 
            // ImporteCompraTextBox
            // 
            this.ImporteCompraTextBox.Location = new System.Drawing.Point(168, 90);
            this.ImporteCompraTextBox.Name = "ImporteCompraTextBox";
            this.ImporteCompraTextBox.Size = new System.Drawing.Size(150, 20);
            this.ImporteCompraTextBox.TabIndex = 67;
            // 
            // TipoTextBox
            // 
            this.TipoTextBox.Location = new System.Drawing.Point(168, 38);
            this.TipoTextBox.Name = "TipoTextBox";
            this.TipoTextBox.Size = new System.Drawing.Size(150, 20);
            this.TipoTextBox.TabIndex = 66;
            // 
            // DescuentoCalculadoLabel
            // 
            this.DescuentoCalculadoLabel.Location = new System.Drawing.Point(12, 113);
            this.DescuentoCalculadoLabel.Name = "DescuentoCalculadoLabel";
            this.DescuentoCalculadoLabel.Size = new System.Drawing.Size(150, 25);
            this.DescuentoCalculadoLabel.TabIndex = 65;
            this.DescuentoCalculadoLabel.Text = "Descuento calculado";
            this.DescuentoCalculadoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ImporteCompraLabel
            // 
            this.ImporteCompraLabel.Location = new System.Drawing.Point(12, 87);
            this.ImporteCompraLabel.Name = "ImporteCompraLabel";
            this.ImporteCompraLabel.Size = new System.Drawing.Size(150, 25);
            this.ImporteCompraLabel.TabIndex = 64;
            this.ImporteCompraLabel.Text = "Importe de compra";
            this.ImporteCompraLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SaldoTextBox
            // 
            this.SaldoTextBox.Location = new System.Drawing.Point(168, 64);
            this.SaldoTextBox.Name = "SaldoTextBox";
            this.SaldoTextBox.Size = new System.Drawing.Size(150, 20);
            this.SaldoTextBox.TabIndex = 63;
            // 
            // SaldoLabel
            // 
            this.SaldoLabel.Location = new System.Drawing.Point(12, 61);
            this.SaldoLabel.Name = "SaldoLabel";
            this.SaldoLabel.Size = new System.Drawing.Size(150, 25);
            this.SaldoLabel.TabIndex = 62;
            this.SaldoLabel.Text = "Saldo";
            this.SaldoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TipoLabel
            // 
            this.TipoLabel.Location = new System.Drawing.Point(12, 35);
            this.TipoLabel.Name = "TipoLabel";
            this.TipoLabel.Size = new System.Drawing.Size(150, 25);
            this.TipoLabel.TabIndex = 61;
            this.TipoLabel.Text = "Tipo";
            this.TipoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GiftcardTextBox
            // 
            this.GiftcardTextBox.Location = new System.Drawing.Point(168, 12);
            this.GiftcardTextBox.Name = "GiftcardTextBox";
            this.GiftcardTextBox.Size = new System.Drawing.Size(150, 20);
            this.GiftcardTextBox.TabIndex = 60;
            // 
            // GiftcardLabel
            // 
            this.GiftcardLabel.Location = new System.Drawing.Point(12, 9);
            this.GiftcardLabel.Name = "GiftcardLabel";
            this.GiftcardLabel.Size = new System.Drawing.Size(150, 25);
            this.GiftcardLabel.TabIndex = 59;
            this.GiftcardLabel.Text = "Gift Card";
            this.GiftcardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RegistrarButton
            // 
            this.RegistrarButton.Location = new System.Drawing.Point(324, 118);
            this.RegistrarButton.Name = "RegistrarButton";
            this.RegistrarButton.Size = new System.Drawing.Size(75, 23);
            this.RegistrarButton.TabIndex = 69;
            this.RegistrarButton.Text = "Registrar";
            this.RegistrarButton.UseVisualStyleBackColor = true;
            // 
            // CompraForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 161);
            this.Controls.Add(this.RegistrarButton);
            this.Controls.Add(this.DescuentoCalculadoTextBox);
            this.Controls.Add(this.ImporteCompraTextBox);
            this.Controls.Add(this.TipoTextBox);
            this.Controls.Add(this.DescuentoCalculadoLabel);
            this.Controls.Add(this.ImporteCompraLabel);
            this.Controls.Add(this.SaldoTextBox);
            this.Controls.Add(this.SaldoLabel);
            this.Controls.Add(this.TipoLabel);
            this.Controls.Add(this.GiftcardTextBox);
            this.Controls.Add(this.GiftcardLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompraForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DescuentoCalculadoTextBox;
        private System.Windows.Forms.TextBox ImporteCompraTextBox;
        private System.Windows.Forms.TextBox TipoTextBox;
        private System.Windows.Forms.Label DescuentoCalculadoLabel;
        private System.Windows.Forms.Label ImporteCompraLabel;
        private System.Windows.Forms.TextBox SaldoTextBox;
        private System.Windows.Forms.Label SaldoLabel;
        private System.Windows.Forms.Label TipoLabel;
        private System.Windows.Forms.TextBox GiftcardTextBox;
        private System.Windows.Forms.Label GiftcardLabel;
        private System.Windows.Forms.Button RegistrarButton;
    }
}