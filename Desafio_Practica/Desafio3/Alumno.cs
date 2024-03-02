using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio3
{
    public class Alumno
    {
        public string Name { get; set; }
        public string Apellido { get; set; }
        public int ID { get; set; }
        public int Grade { get; set; }


        public Alumno(string tName, string Apellido, int id, int grade)
        {
            this.Name = tName;
            this.Apellido = Apellido;
            this.ID = id;
            this.Grade = grade;

        }

        public void UpdateStudent(string tname, string apellido, int grade)
        {
            Name = tname;
            Apellido = apellido;
            Grade= grade;



        }

        public override string ToString()
        {
            return $"ID: {ID}, Nombre: {Name} {Apellido}, Grado: {Grade}";
        }
    }



}

