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
            this.AltaCompraButton = new System.Windows.Forms.Button();
            this.ComprasDataGridView = new System.Windows.Forms.DataGridView();
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
            this.ComprasDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ComprasDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ComprasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ComprasDataGridView.ColumnHeadersHeight = 25;
            this.ComprasDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ComprasDataGridView.Name = "ComprasDataGridView";
            this.ComprasDataGridView.Size = new System.Drawing.Size(600, 300);
            this.ComprasDataGridView.TabIndex = 3;
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
            this.Load += new System.EventHandler(this.ComprasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ComprasDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AltaCompraButton;
        private System.Windows.Forms.DataGridView ComprasDataGridView;
    }
}