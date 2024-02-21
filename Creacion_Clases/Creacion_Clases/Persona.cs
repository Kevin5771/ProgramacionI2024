using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Creacion_Clases
{
    public class Persona
    {
        private int Id { get; set; }
        public string Name { get; set; }
        public string Apellido { get; set; }
        public DateTime Fecha_Nac { get; set; }
        public string Tel { get; set; }
        public  string Direccion {  get; set; }


        /// <summary>
        /// Documentación del Constructor Principal de la Clase Persona
        /// </summary>
        /// <param name="Name"></param>
        /// <param name="Apellido"></param>
        /// <param name="Fecha_Nac"></param>
        /// <param name="Tel"></param>
        /// <param name="Direccion"></param>
        public Persona(int Id,string Name, string Apellido, DateTime Fecha_Nac, string Tel, string Direccion) {
            
            this.Id = Id;
            this.Name = Name;
            this.Apellido = Apellido;
            this.Fecha_Nac = Fecha_Nac;
            this.Tel = Tel;
            this.Direccion = Direccion;
        }
    }
}
