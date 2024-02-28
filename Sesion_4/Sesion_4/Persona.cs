using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesion_4
{
    public class Persona
    {
        private string name;
        private int edad;

        public string Saludar(string s)
        {
            return $"Hola {s}"; }

        public Persona(string name, int edad){
            this.name = name;
            this.edad = 0;
        }


        public static string Saludo(string s)
        {
            return $"Saluda estatico {s}";
        }

        public void Caminar()
        {
            Console.WriteLine($"{name} esta Caminando");
        }
        public int Edad()
        {
            return edad;
        }
    }
}
