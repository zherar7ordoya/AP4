﻿
namespace UI
{
    partial class Categoria
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
            this.CategoriaDGV = new System.Windows.Forms.DataGridView();
            this.AltaButton = new System.Windows.Forms.Button();
            this.ModificacionButton = new System.Windows.Forms.Button();
            this.BajaButton = new System.Windows.Forms.Button();
            this.NombreTextBox = new UI.PlaceHolderTextBox();
            this.CategoriaIDTextBox = new UI.PlaceHolderTextBox();
            this.DescripcionTextBox = new UI.PlaceHolderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoriaDGV
            // 
            this.CategoriaDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriaDGV.Location = new System.Drawing.Point(218, 12);
            this.CategoriaDGV.Name = "CategoriaDGV";
            this.CategoriaDGV.Size = new System.Drawing.Size(400, 162);
            this.CategoriaDGV.TabIndex = 7;
            // 
            // AltaButton
            // 
            this.AltaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltaButton.Location = new System.Drawing.Point(624, 12);
            this.AltaButton.Name = "AltaButton";
            this.AltaButton.Size = new System.Drawing.Size(100, 50);
            this.AltaButton.TabIndex = 1;
            this.AltaButton.Text = "Alta";
            this.AltaButton.UseVisualStyleBackColor = true;
            // 
            // ModificacionButton
            // 
            this.ModificacionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificacionButton.Location = new System.Drawing.Point(624, 124);
            this.ModificacionButton.Name = "ModificacionButton";
            this.ModificacionButton.Size = new System.Drawing.Size(100, 50);
            this.ModificacionButton.TabIndex = 3;
            this.ModificacionButton.Text = "Modificación";
            this.ModificacionButton.UseVisualStyleBackColor = true;
            // 
            // BajaButton
            // 
            this.BajaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BajaButton.Location = new System.Drawing.Point(624, 68);
            this.BajaButton.Name = "BajaButton";
            this.BajaButton.Size = new System.Drawing.Size(100, 50);
            this.BajaButton.TabIndex = 2;
            this.BajaButton.Text = "Baja";
            this.BajaButton.UseVisualStyleBackColor = true;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.NombreTextBox.ForeColor = System.Drawing.Color.Gray;
            this.NombreTextBox.Location = new System.Drawing.Point(12, 68);
            this.NombreTextBox.Multiline = true;
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.PlaceHolderText = "Nombre";
            this.NombreTextBox.Size = new System.Drawing.Size(200, 50);
            this.NombreTextBox.TabIndex = 5;
            this.NombreTextBox.Text = "Nombre";
            // 
            // CategoriaIDTextBox
            // 
            this.CategoriaIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.CategoriaIDTextBox.ForeColor = System.Drawing.Color.Gray;
            this.CategoriaIDTextBox.Location = new System.Drawing.Point(12, 12);
            this.CategoriaIDTextBox.Multiline = true;
            this.CategoriaIDTextBox.Name = "CategoriaIDTextBox";
            this.CategoriaIDTextBox.PlaceHolderText = "CategoriaID";
            this.CategoriaIDTextBox.Size = new System.Drawing.Size(200, 50);
            this.CategoriaIDTextBox.TabIndex = 4;
            this.CategoriaIDTextBox.Text = "CategoriaID";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.DescripcionTextBox.ForeColor = System.Drawing.Color.Gray;
            this.DescripcionTextBox.Location = new System.Drawing.Point(12, 124);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.PlaceHolderText = "Descripción";
            this.DescripcionTextBox.Size = new System.Drawing.Size(200, 50);
            this.DescripcionTextBox.TabIndex = 6;
            this.DescripcionTextBox.Text = "Descripción";
            // 
            // Categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 211);
            this.Controls.Add(this.BajaButton);
            this.Controls.Add(this.ModificacionButton);
            this.Controls.Add(this.AltaButton);
            this.Controls.Add(this.CategoriaDGV);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.CategoriaIDTextBox);
            this.Controls.Add(this.DescripcionTextBox);
            this.Name = "Categoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categoria";
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PlaceHolderTextBox DescripcionTextBox;
        private PlaceHolderTextBox CategoriaIDTextBox;
        private PlaceHolderTextBox NombreTextBox;
        private System.Windows.Forms.DataGridView CategoriaDGV;
        private System.Windows.Forms.Button AltaButton;
        private System.Windows.Forms.Button ModificacionButton;
        private System.Windows.Forms.Button BajaButton;
    }
}