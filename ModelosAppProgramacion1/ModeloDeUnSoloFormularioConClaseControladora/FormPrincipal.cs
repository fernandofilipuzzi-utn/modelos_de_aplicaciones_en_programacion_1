using ModeloDeUnSoloFormularioConClaseControladora.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModeloDeUnSoloFormularioConClaseControladora
{
    public partial class FormPrincipal : Form
    {
        Controlador controlador = new Controlador();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnSolicitudNota_Click(object sender, EventArgs e)
        {
            //recordando como era en consola
            //double nota=Convert.ToDouble(Console.ReadLine());
            double nota = Convert.ToDouble(tbNota.Text);
            controlador.RegistrarNota(nota);

            tbNota.Clear();
        }

        private void btnConsultaPromedio_Click(object sender, EventArgs e)
        {
            double promedio = controlador.CalcularPromedio();

            //recordando como era en consola
            //Console.WriteLine(" El promedio resultante es: {0:f2}", promedio);
            lbPromedio.Text = $"{promedio:f2}";
        }
    }
}
