
namespace UI
{
    partial class Item
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
            this.ProveedorIDTextBox = new UI.PlaceHolderTextBox();
            this.PrecioUnitarioTextBox = new UI.PlaceHolderTextBox();
            this.DescripcionTextBox = new UI.PlaceHolderTextBox();
            this.BajaButton = new System.Windows.Forms.Button();
            this.ModificacionButton = new System.Windows.Forms.Button();
            this.AltaButton = new System.Windows.Forms.Button();
            this.EmpleadoDGV = new System.Windows.Forms.DataGridView();
            this.CategoriaIDTextBox = new UI.PlaceHolderTextBox();
            this.ItemIDTextBox = new UI.PlaceHolderTextBox();
            this.NombreTextBox = new UI.PlaceHolderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // ProveedorIDTextBox
            // 
            this.ProveedorIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.ProveedorIDTextBox.ForeColor = System.Drawing.Color.Gray;
            this.ProveedorIDTextBox.Location = new System.Drawing.Point(12, 292);
            this.ProveedorIDTextBox.Multiline = true;
            this.ProveedorIDTextBox.Name = "ProveedorIDTextBox";
            this.ProveedorIDTextBox.TextoPlaceHolder = "ProveedorID";
            this.ProveedorIDTextBox.Size = new System.Drawing.Size(200, 50);
            this.ProveedorIDTextBox.TabIndex = 20;
            this.ProveedorIDTextBox.Text = "ProveedorID";
            // 
            // PrecioUnitarioTextBox
            // 
            this.PrecioUnitarioTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.PrecioUnitarioTextBox.ForeColor = System.Drawing.Color.Gray;
            this.PrecioUnitarioTextBox.Location = new System.Drawing.Point(12, 236);
            this.PrecioUnitarioTextBox.Multiline = true;
            this.PrecioUnitarioTextBox.Name = "PrecioUnitarioTextBox";
            this.PrecioUnitarioTextBox.TextoPlaceHolder = "Precio Unitario";
            this.PrecioUnitarioTextBox.Size = new System.Drawing.Size(200, 50);
            this.PrecioUnitarioTextBox.TabIndex = 19;
            this.PrecioUnitarioTextBox.Text = "Precio Unitario";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.DescripcionTextBox.ForeColor = System.Drawing.Color.Gray;
            this.DescripcionTextBox.Location = new System.Drawing.Point(12, 180);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.TextoPlaceHolder = "Descripción";
            this.DescripcionTextBox.Size = new System.Drawing.Size(200, 50);
            this.DescripcionTextBox.TabIndex = 18;
            this.DescripcionTextBox.Text = "Descripción";
            // 
            // BajaButton
            // 
            this.BajaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BajaButton.Location = new System.Drawing.Point(624, 68);
            this.BajaButton.Name = "BajaButton";
            this.BajaButton.Size = new System.Drawing.Size(100, 50);
            this.BajaButton.TabIndex = 13;
            this.BajaButton.Text = "Baja";
            this.BajaButton.UseVisualStyleBackColor = true;
            // 
            // ModificacionButton
            // 
            this.ModificacionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModificacionButton.Location = new System.Drawing.Point(624, 124);
            this.ModificacionButton.Name = "ModificacionButton";
            this.ModificacionButton.Size = new System.Drawing.Size(100, 50);
            this.ModificacionButton.TabIndex = 14;
            this.ModificacionButton.Text = "Modificación";
            this.ModificacionButton.UseVisualStyleBackColor = true;
            // 
            // AltaButton
            // 
            this.AltaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AltaButton.Location = new System.Drawing.Point(624, 12);
            this.AltaButton.Name = "AltaButton";
            this.AltaButton.Size = new System.Drawing.Size(100, 50);
            this.AltaButton.TabIndex = 12;
            this.AltaButton.Text = "Alta";
            this.AltaButton.UseVisualStyleBackColor = true;
            // 
            // EmpleadoDGV
            // 
            this.EmpleadoDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmpleadoDGV.Location = new System.Drawing.Point(218, 12);
            this.EmpleadoDGV.Name = "EmpleadoDGV";
            this.EmpleadoDGV.Size = new System.Drawing.Size(400, 162);
            this.EmpleadoDGV.TabIndex = 22;
            // 
            // CategoriaIDTextBox
            // 
            this.CategoriaIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.CategoriaIDTextBox.ForeColor = System.Drawing.Color.Gray;
            this.CategoriaIDTextBox.Location = new System.Drawing.Point(12, 68);
            this.CategoriaIDTextBox.Multiline = true;
            this.CategoriaIDTextBox.Name = "CategoriaIDTextBox";
            this.CategoriaIDTextBox.TextoPlaceHolder = "CategoriaID";
            this.CategoriaIDTextBox.Size = new System.Drawing.Size(200, 50);
            this.CategoriaIDTextBox.TabIndex = 16;
            this.CategoriaIDTextBox.Text = "CategoriaID";
            // 
            // ItemIDTextBox
            // 
            this.ItemIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.ItemIDTextBox.ForeColor = System.Drawing.Color.Gray;
            this.ItemIDTextBox.Location = new System.Drawing.Point(12, 12);
            this.ItemIDTextBox.Multiline = true;
            this.ItemIDTextBox.Name = "ItemIDTextBox";
            this.ItemIDTextBox.TextoPlaceHolder = "ItemID";
            this.ItemIDTextBox.Size = new System.Drawing.Size(200, 50);
            this.ItemIDTextBox.TabIndex = 15;
            this.ItemIDTextBox.Text = "ItemID";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.NombreTextBox.ForeColor = System.Drawing.Color.Gray;
            this.NombreTextBox.Location = new System.Drawing.Point(12, 124);
            this.NombreTextBox.Multiline = true;
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.TextoPlaceHolder = "Nombre";
            this.NombreTextBox.Size = new System.Drawing.Size(200, 50);
            this.NombreTextBox.TabIndex = 17;
            this.NombreTextBox.Text = "Nombre";
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.ProveedorIDTextBox);
            this.Controls.Add(this.PrecioUnitarioTextBox);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.BajaButton);
            this.Controls.Add(this.ModificacionButton);
            this.Controls.Add(this.AltaButton);
            this.Controls.Add(this.EmpleadoDGV);
            this.Controls.Add(this.CategoriaIDTextBox);
            this.Controls.Add(this.ItemIDTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Name = "Item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item";
            ((System.ComponentModel.ISupportInitialize)(this.EmpleadoDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PlaceHolderTextBox ProveedorIDTextBox;
        private PlaceHolderTextBox PrecioUnitarioTextBox;
        private PlaceHolderTextBox DescripcionTextBox;
        private System.Windows.Forms.Button BajaButton;
        private System.Windows.Forms.Button ModificacionButton;
        private System.Windows.Forms.Button AltaButton;
        private System.Windows.Forms.DataGridView EmpleadoDGV;
        private PlaceHolderTextBox CategoriaIDTextBox;
        private PlaceHolderTextBox ItemIDTextBox;
        private PlaceHolderTextBox NombreTextBox;
    }
}