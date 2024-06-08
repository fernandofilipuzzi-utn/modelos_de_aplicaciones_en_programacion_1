using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloAppConsola
{
    class Program
    {
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


        #region métodos para la vista
        /*
           relacionados con las impresiones en pantalla y capturas de datos de la entrada del usuario
        */
        static void MostrarVistaMenu()
        {
            Console.Clear();


            Console.WriteLine(" \t\t Cálculo de promedio de notas\n\n");


            Console.WriteLine("\t1-  Ingrese la nota de un alumno");
            Console.WriteLine("\t2-  Mostrar promedio de las notas cargadas");
            Console.WriteLine("\tOtro-  Cerrar");
        }


        static void MostrarVistaSolicitudNota()
        {
            Console.Clear();
            Console.WriteLine(" \t\t Solicitud de ingreso de nueva nota\n\n");


            Console.WriteLine(" Ingrese a continuación la nota");
            double nota = Convert.ToDouble(Console.ReadLine());


            RegistrarNota(nota);


            Console.WriteLine("Presione una tecla para volver al menú principal");
            Console.ReadKey();
        }


        static void MostrarVistaConsultaPromedio()
        {
            Console.Clear();
            Console.WriteLine(" \t\t Consulta del promedio general\n\n");


            double promedio = CalcularPromedio();
            Console.WriteLine(" El promedio resultante es: {0:f2}", promedio);

            Console.WriteLine("Presione una tecla para volver al menú principal");
            Console.ReadKey();
        }


        #endregion


        static void Main(string[] args)
        {
            int op = 0;

            MostrarVistaMenu();
            op = Convert.ToInt32(Console.ReadLine());


            while (op != 0)
            {
                switch (op)
                {
                    case 1:
                        {
                            MostrarVistaSolicitudNota();
                        }
                        break;
                    case 2:
                        {
                            MostrarVistaConsultaPromedio();
                        }
                        break;
                    default:
                        {
                            op = 0;
                        }
                        break;
                }


                if (op != 0)
                {
                    MostrarVistaMenu();
                    op = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }

}
