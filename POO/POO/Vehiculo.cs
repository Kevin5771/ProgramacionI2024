using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Vehiculo
    {
        // Propiedades
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }

        // Constructor
        public Vehiculo(string marca, string modelo, int año)
        {
            Marca = marca;
            Modelo = modelo;
            Año = año;
        }

        public virtual void Conducir()
        {
            Console.WriteLine($"Conduciendo el vehículo {Marca} {Modelo}");
        }
    }
}
