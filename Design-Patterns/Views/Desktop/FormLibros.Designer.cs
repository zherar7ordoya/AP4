﻿namespace Design_Patterns.Views.Desktop
{
    partial class FormLibros
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
            this.Coelho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Coelho.Font = new System.Drawing.Font("Bookman Old Style", 62F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coelho.Location = new System.Drawing.Point(12, 9);
            this.Coelho.Name = "Coelho";
            this.Coelho.Size = new System.Drawing.Size(776, 408);
            this.Coelho.TabIndex = 0;
            this.Coelho.Text = "Te ahogas, no por caer al río, sino por mantenerte sumergido en él.";
            this.Coelho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 426);
            this.Controls.Add(this.Coelho);
            this.Name = "FormLibros";
            this.Text = "FormLibros";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Coelho;
    }
}