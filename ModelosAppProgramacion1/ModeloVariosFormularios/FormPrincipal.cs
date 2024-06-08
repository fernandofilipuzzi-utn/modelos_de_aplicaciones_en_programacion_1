using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloVariosFormularios
{
    public partial class FormPrincipal : Form
    {
        #region variables y  métodos del dominio del problema
        double acum = 0;
        int contador = 0;

        double CalcularPromedio()
        {
            double promedio = 0;
            if (contador > 0)
                promedio = acum / contador;
            return promedio;
        }

        void RegistrarNota(double nota)
        {
            acum += nota;
            contador++;
        }
        #endregion

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnSolicitudNota_Click(object sender, EventArgs e)
        {
            FormAgregarNota form = new FormAgregarNota();
            if (form.ShowDialog() == DialogResult.OK)
            {
                double nota = Convert.ToInt32(form.tbNota.Text);
                RegistrarNota(nota);
            }
        }

        private void btnConsultaPromedio_Click(object sender, EventArgs e)
        {
            FormVerResultados form = new FormVerResultados();
            form.lbPromedio.Text = $"{CalcularPromedio()}";
            form.ShowDialog();
        }
    }
}
