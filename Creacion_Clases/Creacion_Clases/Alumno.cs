using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_Clases
{
    public class Alumno : Persona
    {
        public string Carnet { get; set; }

        public DateTime Fecha_Ingreso { get; set; }
        public string Carrra_Ingreso { get; set; } 


    // Constructor de Alumno
        public Alumno(int Id, string Name, string Apellido, DateTime Fecha_Nac, string Tel, string Direccion, string Carnet, DateTime Fecha_Ingreso, string Carrera_Ingreso)
        : base(Id,Name, Apellido, Fecha_Nac, Tel, Direccion)
        {
            this.Carnet = Carnet;
            this.Fecha_Ingreso = Fecha_Ingreso;
            this.Carrra_Ingreso= Carrera_Ingreso;
        }
    }
}

