namespace Presentation.Forms
{
    partial class EmpleadosForm
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
            this.panelGuardar = new System.Windows.Forms.Panel();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.tboxFiltrar = new System.Windows.Forms.TextBox();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdAgregar = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxLegajo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxEmail = new System.Windows.Forms.TextBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.panelGuardar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGuardar
            // 
            this.panelGuardar.Controls.Add(this.dtpNacimiento);
            this.panelGuardar.Controls.Add(this.label4);
            this.panelGuardar.Controls.Add(this.tboxEmail);
            this.panelGuardar.Controls.Add(this.label3);
            this.panelGuardar.Controls.Add(this.tboxNombre);
            this.panelGuardar.Controls.Add(this.label2);
            this.panelGuardar.Controls.Add(this.tboxLegajo);
            this.panelGuardar.Controls.Add(this.label1);
            this.panelGuardar.Controls.Add(this.cmdGuardar);
            this.panelGuardar.Location = new System.Drawing.Point(472, 7);
            this.panelGuardar.Name = "panelGuardar";
            this.panelGuardar.Size = new System.Drawing.Size(197, 216);
            this.panelGuardar.TabIndex = 0;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(12, 45);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(454, 134);
            this.dgvEmpleados.TabIndex = 1;
            // 
            // tboxFiltrar
            // 
            this.tboxFiltrar.Location = new System.Drawing.Point(12, 19);
            this.tboxFiltrar.Name = "tboxFiltrar";
            this.tboxFiltrar.Size = new System.Drawing.Size(454, 20);
            this.tboxFiltrar.TabIndex = 2;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(229, 185);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(75, 23);
            this.cmdEliminar.TabIndex = 3;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            // 
            // cmdModificar
            // 
            this.cmdModificar.Location = new System.Drawing.Point(310, 185);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(75, 23);
            this.cmdModificar.TabIndex = 4;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Location = new System.Drawing.Point(391, 185);
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(75, 23);
            this.cmdAgregar.TabIndex = 5;
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.UseVisualStyleBackColor = true;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Location = new System.Drawing.Point(84, 178);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(100, 23);
            this.cmdGuardar.TabIndex = 0;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Legajo";
            // 
            // tboxLegajo
            // 
            this.tboxLegajo.Location = new System.Drawing.Point(84, 12);
            this.tboxLegajo.Name = "tboxLegajo";
            this.tboxLegajo.Size = new System.Drawing.Size(100, 20);
            this.tboxLegajo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(84, 38);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(100, 20);
            this.tboxNombre.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "E-mail";
            // 
            // tboxEmail
            // 
            this.tboxEmail.Location = new System.Drawing.Point(84, 64);
            this.tboxEmail.Name = "tboxEmail";
            this.tboxEmail.Size = new System.Drawing.Size(100, 20);
            this.tboxEmail.TabIndex = 10;
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(85, 91);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(99, 20);
            this.dtpNacimiento.TabIndex = 12;
            // 
            // EmpleadosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 236);
            this.Controls.Add(this.cmdAgregar);
            this.Controls.Add(this.tboxFiltrar);
            this.Controls.Add(this.dgvEmpleados);
            this.Controls.Add(this.panelGuardar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdEliminar);
            this.Name = "EmpleadosForm";
            this.Text = "EmpleadosForm";
            this.Load += new System.EventHandler(this.EmpleadosForm_Load);
            this.panelGuardar.ResumeLayout(false);
            this.panelGuardar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxLegajo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.TextBox tboxFiltrar;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdAgregar;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
    }
}