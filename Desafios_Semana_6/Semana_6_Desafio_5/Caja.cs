using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_6_Desafio_5
{

    public class Caja
    {
        public double Alto { get; set; }
        public double Ancho { get; set; }
        public double Profundidad { get; set; }

        // Constructor
        public Caja(double alto, double ancho, double profundidad)
        {
            Alto = alto;
            Ancho = ancho;
            Profundidad = profundidad;
        }


        public double CalcularVolumen()
        {
            return Alto * Ancho * Profundidad;
        }
    }

}
