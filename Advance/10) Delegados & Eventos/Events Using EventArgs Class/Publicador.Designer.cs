namespace Events_Using_EventArgs_Class
{
    partial class Publicador
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
            this.NewWinformButton = new System.Windows.Forms.Button();
            this.BienvenidaButton = new System.Windows.Forms.Button();
            this.DespedidaButton = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewWinformButton
            // 
            this.NewWinformButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewWinformButton.Location = new System.Drawing.Point(12, 12);
            this.NewWinformButton.Name = "NewWinformButton";
            this.NewWinformButton.Size = new System.Drawing.Size(150, 50);
            this.NewWinformButton.TabIndex = 0;
            this.NewWinformButton.Text = "New Winform";
            this.NewWinformButton.UseVisualStyleBackColor = true;
            this.NewWinformButton.Click += new System.EventHandler(this.NewWinformButton_Click);
            // 
            // BienvenidaButton
            // 
            this.BienvenidaButton.Location = new System.Drawing.Point(50, 100);
            this.BienvenidaButton.Name = "BienvenidaButton";
            this.BienvenidaButton.Size = new System.Drawing.Size(75, 25);
            this.BienvenidaButton.TabIndex = 1;
            this.BienvenidaButton.Text = "Bienvenida";
            this.BienvenidaButton.UseVisualStyleBackColor = true;
            this.BienvenidaButton.Click += new System.EventHandler(this.BienvenidaButton_Click);
            // 
            // DespedidaButton
            // 
            this.DespedidaButton.Location = new System.Drawing.Point(50, 150);
            this.DespedidaButton.Name = "DespedidaButton";
            this.DespedidaButton.Size = new System.Drawing.Size(75, 25);
            this.DespedidaButton.TabIndex = 2;
            this.DespedidaButton.Text = "Despedida";
            this.DespedidaButton.UseVisualStyleBackColor = true;
            this.DespedidaButton.Click += new System.EventHandler(this.DespedidaButton_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 240);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(150, 20);
            this.TextBox.TabIndex = 3;
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(12, 210);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(91, 13);
            this.Label.TabIndex = 4;
            this.Label.Text = "Mensaje enviado:";
            // 
            // Publicador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 291);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.DespedidaButton);
            this.Controls.Add(this.BienvenidaButton);
            this.Controls.Add(this.NewWinformButton);
            this.Name = "Publicador";
            this.Text = "Publicador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewWinformButton;
        private System.Windows.Forms.Button BienvenidaButton;
        private System.Windows.Forms.Button DespedidaButton;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label Label;
    }
}

