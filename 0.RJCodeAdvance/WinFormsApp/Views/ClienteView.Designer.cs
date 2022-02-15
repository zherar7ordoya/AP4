namespace WinFormsApp.Views
{
    partial class ClienteView
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
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.cmdBusqueda = new System.Windows.Forms.Button();
            this.tboxFiltrado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(12, 41);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.RowTemplate.Height = 25;
            this.dgvListado.Size = new System.Drawing.Size(860, 358);
            this.dgvListado.TabIndex = 0;
            // 
            // cmdBusqueda
            // 
            this.cmdBusqueda.Location = new System.Drawing.Point(118, 11);
            this.cmdBusqueda.Name = "cmdBusqueda";
            this.cmdBusqueda.Size = new System.Drawing.Size(75, 23);
            this.cmdBusqueda.TabIndex = 1;
            this.cmdBusqueda.Text = "Buscar";
            this.cmdBusqueda.UseVisualStyleBackColor = true;
            // 
            // tboxFiltrado
            // 
            this.tboxFiltrado.Location = new System.Drawing.Point(12, 12);
            this.tboxFiltrado.Name = "tboxFiltrado";
            this.tboxFiltrado.Size = new System.Drawing.Size(100, 23);
            this.tboxFiltrado.TabIndex = 2;
            // 
            // ClienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.tboxFiltrado);
            this.Controls.Add(this.cmdBusqueda);
            this.Controls.Add(this.dgvListado);
            this.Name = "ClienteView";
            this.Text = "ClienteView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DataGridView dgvListado;
        public Button cmdBusqueda;
        public TextBox tboxFiltrado;
    }
}