namespace MVPExample
{
    partial class CalculadoraForm
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
            this.SumarButton = new System.Windows.Forms.Button();
            this.Valor1Textbox = new System.Windows.Forms.TextBox();
            this.Valor3Textbox = new System.Windows.Forms.TextBox();
            this.TotalTextbox = new System.Windows.Forms.TextBox();
            this.Valor2Textbox = new System.Windows.Forms.TextBox();
            this.ReiniciarButton = new System.Windows.Forms.Button();
            this.lblRunningTotal = new System.Windows.Forms.Label();
            this.AcumuladoTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.SumarButton.Location = new System.Drawing.Point(26, 220);
            this.SumarButton.Name = "btnAdd";
            this.SumarButton.Size = new System.Drawing.Size(121, 49);
            this.SumarButton.TabIndex = 4;
            this.SumarButton.Text = "ADD";
            this.SumarButton.UseVisualStyleBackColor = true;
            // 
            // txtNumber1
            // 
            this.Valor1Textbox.Location = new System.Drawing.Point(26, 26);
            this.Valor1Textbox.Name = "txtNumber1";
            this.Valor1Textbox.Size = new System.Drawing.Size(308, 22);
            this.Valor1Textbox.TabIndex = 0;
            // 
            // txtNumber3
            // 
            this.Valor3Textbox.Location = new System.Drawing.Point(26, 106);
            this.Valor3Textbox.Name = "txtNumber3";
            this.Valor3Textbox.Size = new System.Drawing.Size(308, 22);
            this.Valor3Textbox.TabIndex = 2;
            // 
            // txtTotal
            // 
            this.TotalTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextbox.Location = new System.Drawing.Point(26, 147);
            this.TotalTextbox.Name = "txtTotal";
            this.TotalTextbox.ReadOnly = true;
            this.TotalTextbox.Size = new System.Drawing.Size(308, 34);
            this.TotalTextbox.TabIndex = 3;
            // 
            // txtNumber2
            // 
            this.Valor2Textbox.Location = new System.Drawing.Point(26, 64);
            this.Valor2Textbox.Name = "txtNumber2";
            this.Valor2Textbox.Size = new System.Drawing.Size(308, 22);
            this.Valor2Textbox.TabIndex = 1;
            // 
            // btnReset
            // 
            this.ReiniciarButton.Location = new System.Drawing.Point(213, 220);
            this.ReiniciarButton.Name = "btnReset";
            this.ReiniciarButton.Size = new System.Drawing.Size(121, 49);
            this.ReiniciarButton.TabIndex = 5;
            this.ReiniciarButton.Text = "RESET";
            this.ReiniciarButton.UseVisualStyleBackColor = true;
            // 
            // lblRunningTotal
            // 
            this.lblRunningTotal.AutoSize = true;
            this.lblRunningTotal.Location = new System.Drawing.Point(401, 68);
            this.lblRunningTotal.Name = "lblRunningTotal";
            this.lblRunningTotal.Size = new System.Drawing.Size(101, 17);
            this.lblRunningTotal.TabIndex = 6;
            this.lblRunningTotal.Text = "Running Total:";
            // 
            // txtRunningTotal
            // 
            this.AcumuladoTextbox.Location = new System.Drawing.Point(402, 97);
            this.AcumuladoTextbox.Name = "txtRunningTotal";
            this.AcumuladoTextbox.ReadOnly = true;
            this.AcumuladoTextbox.Size = new System.Drawing.Size(248, 22);
            this.AcumuladoTextbox.TabIndex = 7;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 297);
            this.Controls.Add(this.AcumuladoTextbox);
            this.Controls.Add(this.lblRunningTotal);
            this.Controls.Add(this.ReiniciarButton);
            this.Controls.Add(this.Valor2Textbox);
            this.Controls.Add(this.TotalTextbox);
            this.Controls.Add(this.Valor3Textbox);
            this.Controls.Add(this.Valor1Textbox);
            this.Controls.Add(this.SumarButton);
            this.Name = "CalcForm";
            this.Text = "Calculator v0.01a";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SumarButton;
        private System.Windows.Forms.TextBox Valor1Textbox;
        private System.Windows.Forms.TextBox Valor3Textbox;
        private System.Windows.Forms.TextBox TotalTextbox;
        private System.Windows.Forms.TextBox Valor2Textbox;
        private System.Windows.Forms.Button ReiniciarButton;
        private System.Windows.Forms.Label lblRunningTotal;
        private System.Windows.Forms.TextBox AcumuladoTextbox;
    }
}

