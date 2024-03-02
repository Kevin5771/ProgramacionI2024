using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2_Practica
{
    public class Persona
    {

        public string Nombre { get; set; }
        private string Apellido { get; set; }
        private int Edad { get; set; }
        private int dpi { get; set; }

        public Persona(string Nombre,string Apellido, int Edad , int dpi) {
            
            this.Nombre = Nombre;
            this.Apellido = Apellido; 
            this.Edad = Edad;
            this.dpi = dpi;
         }
    }
}
