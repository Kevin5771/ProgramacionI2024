using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_2
{
    public class Pizarra
    {
        //Atributos del objeto
        public string color;
        private double ancho;
        public double largo;

        public string contenido = "";


        public Pizarra (string color, double ancho, double largo)
        {
            this.color = color;
            this.ancho = ancho;
            this.largo = largo;
        }

        /// <summary>
        /// El método escribe el contenido indicado
        /// </summary>
        /// <param name="texto"></param>
        public void Escribir(string texto)
        {
            
            contenido = contenido + texto;

        }
        /// <summary>
        /// Método que borrara el contenido de la pizarra
        /// </summary>
        public void Borrar() {
            contenido = ""; }

         public String GetContenido () {
            return contenido;
        }

    }
}
