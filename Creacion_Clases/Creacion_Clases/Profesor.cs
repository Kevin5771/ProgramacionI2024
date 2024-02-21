using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creacion_Clases
{
    public class Profesor: Persona
    {
        public string Titulo { get; set; }
        public string Departamento { get; set; }
        private string Cedula { get; set; }

        public Profesor(int Id, string Name, string Apellido, DateTime Fecha_Nac, string Tel, string Direccion,
                        string Titulo, string Departamento, string Cedula) : base(Id, Name, Apellido, Fecha_Nac, Tel, Direccion)
        {
            this.Titulo = Titulo;
            this.Departamento = Departamento;
            this.Cedula = Cedula;

        }
    }
}
