using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Desafio2_Practica
{
    internal class Empleado : Persona
    {
        private string Cargo { get; set; }
        private double Salario { get; set; }

        // Constructor
        public Empleado(string Nombre, string Apellido, int Edad, int dpi, string cargo, double salario) : base(Nombre, Apellido, Edad, dpi)
        {
            Cargo = cargo;
            Salario = salario;
        }

        // Método para actualizar la información del empleado
        public void ActualizarInformacion(string Nombre, string Apellido, int Edad, string cargo, double salario)
        {
            Nombre = Nombre;
            Apellido = Apellido;
            Edad = Edad;
            Cargo = cargo;
            Salario = salario;
        }
    }

}