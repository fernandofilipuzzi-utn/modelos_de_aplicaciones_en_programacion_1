using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloDeUnSoloFormularioConClaseControladora.Models
{
    public class Controlador
    {
        #region variables y  métodos del dominio del problema
        public double acum;
        public int contador;

        public double CalcularPromedio()
        {
            double promedio = 0;
            if (contador > 0)
                promedio = acum / contador;
            return promedio;
        }

        public void RegistrarNota(double nota)
        {
            acum += nota;
            contador++;
        }
        #endregion
    }
}
