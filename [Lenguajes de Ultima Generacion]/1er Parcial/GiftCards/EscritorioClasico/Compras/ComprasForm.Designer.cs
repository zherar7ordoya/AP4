namespace EscritorioClasico.Compras
{
    partial class ComprasForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComprasForm));
            this.AltaCompraButton = new System.Windows.Forms.Button();
            this.ComprasDataGridView = new System.Windows.Forms.DataGridView();
            this.Borrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Temporal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ComprasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AltaCompraButton
            // 
            this.AltaCompraButton.Location = new System.Drawing.Point(618, 289);
            this.AltaCompraButton.Name = "AltaCompraButton";
            this.AltaCompraButton.Size = new System.Drawing.Size(75, 23);
            this.AltaCompraButton.TabIndex = 0;
            this.AltaCompraButton.Text = "Alta";
            this.AltaCompraButton.UseVisualStyleBackColor = true;
            this.AltaCompraButton.Click += new System.EventHandler(this.AltaCompraButton_Click);
            // 
            // ComprasDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ComprasDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ComprasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ComprasDataGridView.ColumnHeadersHeight = 25;
            this.ComprasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Borrar,
            this.Editar,
            this.Temporal});
            this.ComprasDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ComprasDataGridView.Name = "ComprasDataGridView";
            this.ComprasDataGridView.Size = new System.Drawing.Size(600, 300);
            this.ComprasDataGridView.TabIndex = 3;
            // 
            // Borrar
            // 
            this.Borrar.HeaderText = "Borrar";
            this.Borrar.Image = ((System.Drawing.Image)(resources.GetObject("Borrar.Image")));
            this.Borrar.Name = "Borrar";
            this.Borrar.Width = 41;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = ((System.Drawing.Image)(resources.GetObject("Editar.Image")));
            this.Editar.Name = "Editar";
            this.Editar.Width = 40;
            // 
            // Temporal
            // 
            this.Temporal.HeaderText = "Temporal";
            this.Temporal.Name = "Temporal";
            this.Temporal.Width = 76;
            // 
            // ComprasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 361);
            this.Controls.Add(this.ComprasDataGridView);
            this.Controls.Add(this.AltaCompraButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ComprasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComprasForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ComprasDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AltaCompraButton;
        private System.Windows.Forms.DataGridView ComprasDataGridView;
        private System.Windows.Forms.DataGridViewImageColumn Borrar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temporal;
    }
}