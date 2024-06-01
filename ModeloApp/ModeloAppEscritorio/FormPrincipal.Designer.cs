namespace ModeloAppEscritorio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.btnSolicitudNota = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConsultaPromedio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPromedio = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbNota);
            this.groupBox1.Controls.Add(this.btnSolicitudNota);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solicitud de ingreso de nueva nota";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese a continuación la nota";
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(186, 46);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(106, 20);
            this.tbNota.TabIndex = 1;
            // 
            // btnSolicitudNota
            // 
            this.btnSolicitudNota.Location = new System.Drawing.Point(113, 84);
            this.btnSolicitudNota.Name = "btnSolicitudNota";
            this.btnSolicitudNota.Size = new System.Drawing.Size(107, 23);
            this.btnSolicitudNota.TabIndex = 0;
            this.btnSolicitudNota.Text = "Agregar Nota";
            this.btnSolicitudNota.UseVisualStyleBackColor = true;
            this.btnSolicitudNota.Click += new System.EventHandler(this.btnSolicitudNota_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbPromedio);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnConsultaPromedio);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consulta del promedio general";
            // 
            // btnConsultaPromedio
            // 
            this.btnConsultaPromedio.Location = new System.Drawing.Point(113, 77);
            this.btnConsultaPromedio.Name = "btnConsultaPromedio";
            this.btnConsultaPromedio.Size = new System.Drawing.Size(107, 23);
            this.btnConsultaPromedio.TabIndex = 1;
            this.btnConsultaPromedio.Text = "Consulta Promedio";
            this.btnConsultaPromedio.UseVisualStyleBackColor = true;
            this.btnConsultaPromedio.Click += new System.EventHandler(this.btnConsultaPromedio_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "El promedio resultante es:";
            // 
            // lbPromedio
            // 
            this.lbPromedio.AutoSize = true;
            this.lbPromedio.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbPromedio.Location = new System.Drawing.Point(175, 41);
            this.lbPromedio.Name = "lbPromedio";
            this.lbPromedio.Size = new System.Drawing.Size(19, 13);
            this.lbPromedio.TabIndex = 4;
            this.lbPromedio.Text = "    ";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 241);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPrincipal";
            this.Text = "Modelo de Aplicación de Ventanas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbNota;
        private System.Windows.Forms.Button btnSolicitudNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultaPromedio;
        private System.Windows.Forms.Label lbPromedio;
        private System.Windows.Forms.Label label2;
    }
}

