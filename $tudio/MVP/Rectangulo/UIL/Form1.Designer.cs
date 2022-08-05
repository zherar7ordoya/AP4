
namespace UIL
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LongitudTextbox = new UI.PlaceHolderTextBox();
            this.AmplitudTextbox = new UI.PlaceHolderTextBox();
            this.AreaButton = new System.Windows.Forms.Button();
            this.ResultadoTextbox = new UI.PlaceHolderTextBox();
            this.SuspendLayout();
            // 
            // LongitudTextbox
            // 
            this.LongitudTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.LongitudTextbox.ForeColor = System.Drawing.Color.DarkBlue;
            this.LongitudTextbox.Location = new System.Drawing.Point(13, 13);
            this.LongitudTextbox.Name = "LongitudTextbox";
            this.LongitudTextbox.Size = new System.Drawing.Size(136, 20);
            this.LongitudTextbox.TabIndex = 0;
            this.LongitudTextbox.Text = "Longitud";
            this.LongitudTextbox.TextoPlaceHolder = "Longitud";
            // 
            // AmplitudTextbox
            // 
            this.AmplitudTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.AmplitudTextbox.ForeColor = System.Drawing.Color.DarkBlue;
            this.AmplitudTextbox.Location = new System.Drawing.Point(13, 39);
            this.AmplitudTextbox.Name = "AmplitudTextbox";
            this.AmplitudTextbox.Size = new System.Drawing.Size(136, 20);
            this.AmplitudTextbox.TabIndex = 1;
            this.AmplitudTextbox.Text = "Amplitud";
            this.AmplitudTextbox.TextoPlaceHolder = "Amplitud";
            // 
            // AreaButton
            // 
            this.AreaButton.Location = new System.Drawing.Point(13, 66);
            this.AreaButton.Name = "AreaButton";
            this.AreaButton.Size = new System.Drawing.Size(136, 23);
            this.AreaButton.TabIndex = 2;
            this.AreaButton.Text = "Area";
            this.AreaButton.UseVisualStyleBackColor = true;
            // 
            // ResultadoTextbox
            // 
            this.ResultadoTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
            this.ResultadoTextbox.ForeColor = System.Drawing.Color.DarkBlue;
            this.ResultadoTextbox.Location = new System.Drawing.Point(13, 95);
            this.ResultadoTextbox.Name = "ResultadoTextbox";
            this.ResultadoTextbox.Size = new System.Drawing.Size(136, 20);
            this.ResultadoTextbox.TabIndex = 3;
            this.ResultadoTextbox.Text = "Resultado";
            this.ResultadoTextbox.TextoPlaceHolder = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(161, 132);
            this.Controls.Add(this.ResultadoTextbox);
            this.Controls.Add(this.AreaButton);
            this.Controls.Add(this.AmplitudTextbox);
            this.Controls.Add(this.LongitudTextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UI.PlaceHolderTextBox LongitudTextbox;
        private UI.PlaceHolderTextBox AmplitudTextbox;
        private System.Windows.Forms.Button AreaButton;
        private UI.PlaceHolderTextBox ResultadoTextbox;
    }
}

