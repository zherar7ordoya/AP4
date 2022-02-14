namespace Design_Patterns.Views.Desktop
{
    partial class FormPrincipal
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
            this.menuFormularios = new System.Windows.Forms.MenuStrip();
            this.itemClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormularios.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuFormularios
            // 
            this.menuFormularios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemClientes,
            this.itemLibros});
            this.menuFormularios.Location = new System.Drawing.Point(0, 0);
            this.menuFormularios.Name = "menuFormularios";
            this.menuFormularios.Size = new System.Drawing.Size(800, 24);
            this.menuFormularios.TabIndex = 0;
            this.menuFormularios.Text = "menuStrip1";
            // 
            // itemClientes
            // 
            this.itemClientes.Name = "itemClientes";
            this.itemClientes.Size = new System.Drawing.Size(61, 20);
            this.itemClientes.Text = "Clientes";
            this.itemClientes.Click += new System.EventHandler(this.itemClientes_Click);
            // 
            // itemLibros
            // 
            this.itemLibros.Name = "itemLibros";
            this.itemLibros.Size = new System.Drawing.Size(51, 20);
            this.itemLibros.Text = "Libros";
            this.itemLibros.Click += new System.EventHandler(this.itemLibros_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuFormularios);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuFormularios;
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.menuFormularios.ResumeLayout(false);
            this.menuFormularios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuFormularios;
        private System.Windows.Forms.ToolStripMenuItem itemClientes;
        private System.Windows.Forms.ToolStripMenuItem itemLibros;
    }
}