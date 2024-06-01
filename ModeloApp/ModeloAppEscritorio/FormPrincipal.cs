using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloAppEscritorio
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        #region variables y  métodos del dominio del problema
        static double acum;
        static int contador;


        static double CalcularPromedio()
        {
            double promedio = 0;
            if (contador > 0)
                promedio = acum / contador;
            return promedio;
        }


        static void RegistrarNota(double nota)
        {
            acum += nota;
            contador++;
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSolicitudNota_Click(object sender, EventArgs e)
        {
            //double nota=Convert.ToDouble(Console.ReadLine());
            double nota = Convert.ToDouble(tbNota.Text);
            RegistrarNota(nota);

            tbNota.Clear();
        }

        private void btnConsultaPromedio_Click(object sender, EventArgs e)
        {
            double promedio = CalcularPromedio();

            //Console.WriteLine(" El promedio resultante es: {0:f2}", promedio);
            lbPromedio.Text = $"{promedio:f2}";
        }
    }
}
