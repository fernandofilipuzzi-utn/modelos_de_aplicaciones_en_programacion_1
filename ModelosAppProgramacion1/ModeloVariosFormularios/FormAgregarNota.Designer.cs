namespace ModeloVariosFormularios
{
    partial class FormAgregarNota
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.btnSolicitudNota = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbNota);
            this.groupBox1.Controls.Add(this.btnSolicitudNota);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(394, 174);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solicitud de ingreso de nueva nota";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese a continuación la nota";
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(98, 68);
            this.tbNota.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(157, 26);
            this.tbNota.TabIndex = 1;
            // 
            // btnSolicitudNota
            // 
            this.btnSolicitudNota.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSolicitudNota.Location = new System.Drawing.Point(98, 126);
            this.btnSolicitudNota.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSolicitudNota.Name = "btnSolicitudNota";
            this.btnSolicitudNota.Size = new System.Drawing.Size(160, 35);
            this.btnSolicitudNota.TabIndex = 0;
            this.btnSolicitudNota.Text = "Agregar Nota";
            this.btnSolicitudNota.UseVisualStyleBackColor = true;
            // 
            // FormAgregarNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 198);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAgregarNota";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dialogo de solicitud de nueva nota";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSolicitudNota;
        public System.Windows.Forms.TextBox tbNota;
    }
}