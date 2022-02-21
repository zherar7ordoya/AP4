namespace CP_CapaPresentacion
{
    partial class CP_Productos
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.cmdAgregarProducto = new System.Windows.Forms.Button();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxStock = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxMarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxId = new System.Windows.Forms.TextBox();
            this.cmdEditarProducto = new System.Windows.Forms.Button();
            this.cmdEliminarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(13, 13);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(388, 425);
            this.dgvProductos.TabIndex = 0;
            // 
            // cmdAgregarProducto
            // 
            this.cmdAgregarProducto.Location = new System.Drawing.Point(579, 196);
            this.cmdAgregarProducto.Name = "cmdAgregarProducto";
            this.cmdAgregarProducto.Size = new System.Drawing.Size(172, 23);
            this.cmdAgregarProducto.TabIndex = 1;
            this.cmdAgregarProducto.Text = "Agregar Producto";
            this.cmdAgregarProducto.UseVisualStyleBackColor = true;
            this.cmdAgregarProducto.Click += new System.EventHandler(this.cmdAgregarProducto_Click);
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(651, 66);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(100, 20);
            this.tboxNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stock: ";
            // 
            // tboxStock
            // 
            this.tboxStock.Location = new System.Drawing.Point(651, 170);
            this.tboxStock.Name = "tboxStock";
            this.tboxStock.Size = new System.Drawing.Size(100, 20);
            this.tboxStock.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio: ";
            // 
            // tboxPrecio
            // 
            this.tboxPrecio.Location = new System.Drawing.Point(651, 144);
            this.tboxPrecio.Name = "tboxPrecio";
            this.tboxPrecio.Size = new System.Drawing.Size(100, 20);
            this.tboxPrecio.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Marca: ";
            // 
            // tboxMarca
            // 
            this.tboxMarca.Location = new System.Drawing.Point(651, 118);
            this.tboxMarca.Name = "tboxMarca";
            this.tboxMarca.Size = new System.Drawing.Size(100, 20);
            this.tboxMarca.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(576, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Descripción: ";
            // 
            // tboxDescripcion
            // 
            this.tboxDescripcion.Location = new System.Drawing.Point(651, 92);
            this.tboxDescripcion.Name = "tboxDescripcion";
            this.tboxDescripcion.Size = new System.Drawing.Size(100, 20);
            this.tboxDescripcion.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(576, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Id: ";
            // 
            // tboxId
            // 
            this.tboxId.Location = new System.Drawing.Point(651, 40);
            this.tboxId.Name = "tboxId";
            this.tboxId.Size = new System.Drawing.Size(100, 20);
            this.tboxId.TabIndex = 12;
            // 
            // cmdEditarProducto
            // 
            this.cmdEditarProducto.Location = new System.Drawing.Point(579, 225);
            this.cmdEditarProducto.Name = "cmdEditarProducto";
            this.cmdEditarProducto.Size = new System.Drawing.Size(172, 23);
            this.cmdEditarProducto.TabIndex = 14;
            this.cmdEditarProducto.Text = "Editar Producto";
            this.cmdEditarProducto.UseVisualStyleBackColor = true;
            this.cmdEditarProducto.Click += new System.EventHandler(this.cmdEditarProducto_Click);
            // 
            // cmdEliminarProducto
            // 
            this.cmdEliminarProducto.Location = new System.Drawing.Point(579, 254);
            this.cmdEliminarProducto.Name = "cmdEliminarProducto";
            this.cmdEliminarProducto.Size = new System.Drawing.Size(172, 23);
            this.cmdEliminarProducto.TabIndex = 15;
            this.cmdEliminarProducto.Text = "Eliminar Producto";
            this.cmdEliminarProducto.UseVisualStyleBackColor = true;
            this.cmdEliminarProducto.Click += new System.EventHandler(this.cmdEliminarProducto_Click);
            // 
            // CP_Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdEliminarProducto);
            this.Controls.Add(this.cmdEditarProducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tboxId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tboxDescripcion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tboxPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.cmdAgregarProducto);
            this.Controls.Add(this.dgvProductos);
            this.Name = "CP_Productos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CP_Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button cmdAgregarProducto;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxId;
        private System.Windows.Forms.Button cmdEditarProducto;
        private System.Windows.Forms.Button cmdEliminarProducto;
    }
}

