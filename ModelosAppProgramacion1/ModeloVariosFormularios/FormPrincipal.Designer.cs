namespace ModeloVariosFormularios
{
    partial class FormPrincipal
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
            this.btnConsultaPromedio = new System.Windows.Forms.Button();
            this.btnSolicitudNota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultaPromedio
            // 
            this.btnConsultaPromedio.Location = new System.Drawing.Point(30, 71);
            this.btnConsultaPromedio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConsultaPromedio.Name = "btnConsultaPromedio";
            this.btnConsultaPromedio.Size = new System.Drawing.Size(160, 35);
            this.btnConsultaPromedio.TabIndex = 1;
            this.btnConsultaPromedio.Text = "Consulta Promedio";
            this.btnConsultaPromedio.UseVisualStyleBackColor = true;
            this.btnConsultaPromedio.Click += new System.EventHandler(this.btnConsultaPromedio_Click);
            // 
            // btnSolicitudNota
            // 
            this.btnSolicitudNota.Location = new System.Drawing.Point(30, 26);
            this.btnSolicitudNota.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSolicitudNota.Name = "btnSolicitudNota";
            this.btnSolicitudNota.Size = new System.Drawing.Size(160, 35);
            this.btnSolicitudNota.TabIndex = 0;
            this.btnSolicitudNota.Text = "Agregar Nota";
            this.btnSolicitudNota.UseVisualStyleBackColor = true;
            this.btnSolicitudNota.Click += new System.EventHandler(this.btnSolicitudNota_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 119);
            this.Controls.Add(this.btnSolicitudNota);
            this.Controls.Add(this.btnConsultaPromedio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.Text = "Menu principal";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConsultaPromedio;
        private System.Windows.Forms.Button btnSolicitudNota;
    }
}

