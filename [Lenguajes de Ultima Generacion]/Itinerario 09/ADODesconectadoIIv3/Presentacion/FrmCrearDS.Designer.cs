namespace Presentacion
{
    partial class FrmCrearDS
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
            this.Label2 = new System.Windows.Forms.Label();
            this.grdPaises = new System.Windows.Forms.DataGridView();
            this.BtnMostrarDs = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.BtnCargarDs = new System.Windows.Forms.Button();
            this.BtnCrearDs = new System.Windows.Forms.Button();
            this.grdPersonas = new System.Windows.Forms.DataGridView();
            this.groupBoxFiltros = new System.Windows.Forms.GroupBox();
            this.dataGridfiltros = new System.Windows.Forms.DataGridView();
            this.TxfiltroData = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInicio = new System.Windows.Forms.TextBox();
            this.txtFin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_filtro_dataview = new System.Windows.Forms.Button();
            this.btn_FiltroDatatable = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.rdbPais = new System.Windows.Forms.RadioButton();
            this.rdbApe = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdPaises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPersonas)).BeginInit();
            this.groupBoxFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridfiltros)).BeginInit();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(13, 45);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(41, 13);
            this.Label2.TabIndex = 27;
            this.Label2.Text = "Paises:";
            // 
            // grdPaises
            // 
            this.grdPaises.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPaises.Location = new System.Drawing.Point(12, 61);
            this.grdPaises.Name = "grdPaises";
            this.grdPaises.Size = new System.Drawing.Size(258, 262);
            this.grdPaises.TabIndex = 26;
            // 
            // BtnMostrarDs
            // 
            this.BtnMostrarDs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMostrarDs.Location = new System.Drawing.Point(736, 12);
            this.BtnMostrarDs.Name = "BtnMostrarDs";
            this.BtnMostrarDs.Size = new System.Drawing.Size(113, 23);
            this.BtnMostrarDs.TabIndex = 25;
            this.BtnMostrarDs.Text = "Mostrar Dataset";
            this.BtnMostrarDs.UseVisualStyleBackColor = true;
            this.BtnMostrarDs.Click += new System.EventHandler(this.BtnMostrarDs_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(12, 10);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(440, 20);
            this.Label3.TabIndex = 24;
            this.Label3.Text = "Creación del Dataset en memoria (Sin Base de datos)";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(296, 45);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(54, 13);
            this.Label1.TabIndex = 23;
            this.Label1.Text = "Personas:";
            // 
            // BtnCargarDs
            // 
            this.BtnCargarDs.Location = new System.Drawing.Point(589, 12);
            this.BtnCargarDs.Name = "BtnCargarDs";
            this.BtnCargarDs.Size = new System.Drawing.Size(113, 23);
            this.BtnCargarDs.TabIndex = 22;
            this.BtnCargarDs.Text = "Cargar Dataset";
            this.BtnCargarDs.UseVisualStyleBackColor = true;
            this.BtnCargarDs.Click += new System.EventHandler(this.BtnCargarDs_Click);
            // 
            // BtnCrearDs
            // 
            this.BtnCrearDs.Location = new System.Drawing.Point(458, 12);
            this.BtnCrearDs.Name = "BtnCrearDs";
            this.BtnCrearDs.Size = new System.Drawing.Size(113, 23);
            this.BtnCrearDs.TabIndex = 21;
            this.BtnCrearDs.Text = "Crear Dataset";
            this.BtnCrearDs.UseVisualStyleBackColor = true;
            this.BtnCrearDs.Click += new System.EventHandler(this.BtnCrearDs_Click);
            // 
            // grdPersonas
            // 
            this.grdPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPersonas.Location = new System.Drawing.Point(289, 61);
            this.grdPersonas.Name = "grdPersonas";
            this.grdPersonas.Size = new System.Drawing.Size(629, 262);
            this.grdPersonas.TabIndex = 20;
            // 
            // groupBoxFiltros
            // 
            this.groupBoxFiltros.Controls.Add(this.rdbApe);
            this.groupBoxFiltros.Controls.Add(this.rdbPais);
            this.groupBoxFiltros.Controls.Add(this.button1);
            this.groupBoxFiltros.Controls.Add(this.dataGridfiltros);
            this.groupBoxFiltros.Controls.Add(this.TxfiltroData);
            this.groupBoxFiltros.Controls.Add(this.label5);
            this.groupBoxFiltros.Controls.Add(this.txtInicio);
            this.groupBoxFiltros.Controls.Add(this.txtFin);
            this.groupBoxFiltros.Controls.Add(this.label4);
            this.groupBoxFiltros.Controls.Add(this.btn_filtro_dataview);
            this.groupBoxFiltros.Controls.Add(this.btn_FiltroDatatable);
            this.groupBoxFiltros.Location = new System.Drawing.Point(16, 326);
            this.groupBoxFiltros.Name = "groupBoxFiltros";
            this.groupBoxFiltros.Size = new System.Drawing.Size(805, 266);
            this.groupBoxFiltros.TabIndex = 28;
            this.groupBoxFiltros.TabStop = false;
            this.groupBoxFiltros.Text = "Filtros";
            // 
            // dataGridfiltros
            // 
            this.dataGridfiltros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridfiltros.Location = new System.Drawing.Point(30, 89);
            this.dataGridfiltros.Name = "dataGridfiltros";
            this.dataGridfiltros.Size = new System.Drawing.Size(629, 168);
            this.dataGridfiltros.TabIndex = 29;
            // 
            // TxfiltroData
            // 
            this.TxfiltroData.Location = new System.Drawing.Point(390, 63);
            this.TxfiltroData.Name = "TxfiltroData";
            this.TxfiltroData.Size = new System.Drawing.Size(224, 20);
            this.TxfiltroData.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(496, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "y";
            // 
            // txtInicio
            // 
            this.txtInicio.Location = new System.Drawing.Point(390, 24);
            this.txtInicio.Name = "txtInicio";
            this.txtInicio.Size = new System.Drawing.Size(100, 20);
            this.txtInicio.TabIndex = 1;
            // 
            // txtFin
            // 
            this.txtFin.Location = new System.Drawing.Point(514, 24);
            this.txtFin.Name = "txtFin";
            this.txtFin.Size = new System.Drawing.Size(100, 20);
            this.txtFin.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Todos los que nacieron entre los años ...";
            // 
            // btn_filtro_dataview
            // 
            this.btn_filtro_dataview.Location = new System.Drawing.Point(30, 57);
            this.btn_filtro_dataview.Name = "btn_filtro_dataview";
            this.btn_filtro_dataview.Size = new System.Drawing.Size(151, 23);
            this.btn_filtro_dataview.TabIndex = 3;
            this.btn_filtro_dataview.Text = "Filtrar x  Dataview";
            this.btn_filtro_dataview.UseVisualStyleBackColor = true;
            this.btn_filtro_dataview.Click += new System.EventHandler(this.btn_filtro_dataview_Click);
            // 
            // btn_FiltroDatatable
            // 
            this.btn_FiltroDatatable.Location = new System.Drawing.Point(30, 19);
            this.btn_FiltroDatatable.Name = "btn_FiltroDatatable";
            this.btn_FiltroDatatable.Size = new System.Drawing.Size(151, 23);
            this.btn_FiltroDatatable.TabIndex = 0;
            this.btn_FiltroDatatable.Text = "Filtrar x  Datatable";
            this.btn_FiltroDatatable.UseVisualStyleBackColor = true;
            this.btn_FiltroDatatable.Click += new System.EventHandler(this.btn_FiltroDatatable_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 53);
            this.button1.TabIndex = 30;
            this.button1.Text = "Limpiar Filtro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdbPais
            // 
            this.rdbPais.AutoSize = true;
            this.rdbPais.Location = new System.Drawing.Point(202, 62);
            this.rdbPais.Name = "rdbPais";
            this.rdbPais.Size = new System.Drawing.Size(96, 17);
            this.rdbPais.TabIndex = 32;
            this.rdbPais.TabStop = true;
            this.rdbPais.Text = "Código de Pais";
            this.rdbPais.UseVisualStyleBackColor = true;
            // 
            // rdbApe
            // 
            this.rdbApe.AutoSize = true;
            this.rdbApe.Location = new System.Drawing.Point(317, 63);
            this.rdbApe.Name = "rdbApe";
            this.rdbApe.Size = new System.Drawing.Size(62, 17);
            this.rdbApe.TabIndex = 33;
            this.rdbApe.TabStop = true;
            this.rdbApe.Text = "Apellido";
            this.rdbApe.UseVisualStyleBackColor = true;
            // 
            // FrmCrearDS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 595);
            this.Controls.Add(this.groupBoxFiltros);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.grdPaises);
            this.Controls.Add(this.BtnMostrarDs);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.BtnCargarDs);
            this.Controls.Add(this.BtnCrearDs);
            this.Controls.Add(this.grdPersonas);
            this.Name = "FrmCrearDS";
            this.Text = "CrearDS - Sin Base de Datos";
            this.Load += new System.EventHandler(this.FrmCrearDS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPaises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPersonas)).EndInit();
            this.groupBoxFiltros.ResumeLayout(false);
            this.groupBoxFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridfiltros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DataGridView grdPaises;
        internal System.Windows.Forms.Button BtnMostrarDs;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button BtnCargarDs;
        internal System.Windows.Forms.Button BtnCrearDs;
        internal System.Windows.Forms.DataGridView grdPersonas;
        private System.Windows.Forms.GroupBox groupBoxFiltros;
        internal System.Windows.Forms.DataGridView dataGridfiltros;
        internal System.Windows.Forms.TextBox TxfiltroData;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtInicio;
        internal System.Windows.Forms.TextBox txtFin;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_filtro_dataview;
        private System.Windows.Forms.Button btn_FiltroDatatable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdbApe;
        private System.Windows.Forms.RadioButton rdbPais;
    }
}