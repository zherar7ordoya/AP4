namespace DesignPatterns.UI.Desktop
{
    partial class FormularioLibros
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
            this.Coelho = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Coelho
            // 
            this.Coelho.Font = new System.Drawing.Font("Lucida Calligraphy", 59F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Coelho.Location = new System.Drawing.Point(12, 9);
            this.Coelho.Name = "Coelho";
            this.Coelho.Size = new System.Drawing.Size(776, 432);
            this.Coelho.TabIndex = 0;
            this.Coelho.Text = "Te ahogas, no por caer al río, sino por mantenerte sumergido en él.";
            this.Coelho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormularioLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Coelho);
            this.Name = "FormularioLibros";
            this.Text = "Libros";
            this.ResumeLayout(false);

        }

        #endregion

        private Label Coelho;
    }
}