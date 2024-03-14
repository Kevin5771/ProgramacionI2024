using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_6_Desafio_4
{
    public class Medidaas
    {
        public int Alto { get; set; }
        public int Ancho { get; set; }

        // Constructor que inicializa alto y ancho
        public Medidaas(int alto, int ancho)
        {
            Alto = alto;
            Ancho = ancho;
        }

        public int CalcularSuperficie()
        {
            return Alto * Ancho;
        }
    }
}
