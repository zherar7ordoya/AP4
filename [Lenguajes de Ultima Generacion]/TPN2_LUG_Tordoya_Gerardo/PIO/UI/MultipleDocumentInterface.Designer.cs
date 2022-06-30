
namespace UI
{
    partial class MultipleDocumentInterface
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.ABMMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoriasMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DepartamentosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpleadosMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrdenesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProveedoresMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RolesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArchivoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArchivoMenu,
            this.ABMMenu});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // ABMMenu
            // 
            this.ABMMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CategoriasMenuItem,
            this.DepartamentosMenuItem,
            this.EmpleadosMenuItem,
            this.ItemsMenuItem,
            this.OrdenesMenuItem,
            this.ProveedoresMenuItem,
            this.RolesMenuItem});
            this.ABMMenu.Name = "ABMMenu";
            this.ABMMenu.Size = new System.Drawing.Size(45, 20);
            this.ABMMenu.Text = "ABM";
            // 
            // CategoriasMenuItem
            // 
            this.CategoriasMenuItem.Name = "CategoriasMenuItem";
            this.CategoriasMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CategoriasMenuItem.Text = "Categorías";
            // 
            // DepartamentosMenuItem
            // 
            this.DepartamentosMenuItem.Name = "DepartamentosMenuItem";
            this.DepartamentosMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DepartamentosMenuItem.Text = "Departamentos";
            // 
            // EmpleadosMenuItem
            // 
            this.EmpleadosMenuItem.Name = "EmpleadosMenuItem";
            this.EmpleadosMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EmpleadosMenuItem.Text = "Empleados";
            // 
            // ItemsMenuItem
            // 
            this.ItemsMenuItem.Name = "ItemsMenuItem";
            this.ItemsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ItemsMenuItem.Text = "Ítems";
            // 
            // OrdenesMenuItem
            // 
            this.OrdenesMenuItem.Name = "OrdenesMenuItem";
            this.OrdenesMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OrdenesMenuItem.Text = "Órdenes";
            // 
            // ProveedoresMenuItem
            // 
            this.ProveedoresMenuItem.Name = "ProveedoresMenuItem";
            this.ProveedoresMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ProveedoresMenuItem.Text = "Proveedores";
            // 
            // RolesMenuItem
            // 
            this.RolesMenuItem.Name = "RolesMenuItem";
            this.RolesMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RolesMenuItem.Text = "Roles";
            // 
            // ArchivoMenu
            // 
            this.ArchivoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalirMenuItem});
            this.ArchivoMenu.Name = "ArchivoMenu";
            this.ArchivoMenu.Size = new System.Drawing.Size(60, 20);
            this.ArchivoMenu.Text = "Archivo";
            // 
            // SalirMenuItem
            // 
            this.SalirMenuItem.Name = "SalirMenuItem";
            this.SalirMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SalirMenuItem.Text = "Salir";
            this.SalirMenuItem.Click += new System.EventHandler(this.SalirMenuItem_Click);
            // 
            // MultipleDocumentInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MultipleDocumentInterface";
            this.Text = "Menú";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ArchivoMenu;
        private System.Windows.Forms.ToolStripMenuItem SalirMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ABMMenu;
        private System.Windows.Forms.ToolStripMenuItem CategoriasMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DepartamentosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmpleadosMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ItemsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OrdenesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProveedoresMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RolesMenuItem;
    }
}

