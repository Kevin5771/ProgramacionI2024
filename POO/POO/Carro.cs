using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Carro : Vehiculo
    {
        // Propiedades específicas de Carro
        public int NumeroPuertas { get; set; }
        public string Color { get; set; }
        public double VelocidadActual { get; private set; }
        public bool MotorEncendido { get; private set; }


        // Constructor
        public Carro(string marca, string modelo, int año, int numeroPuertas, string color) : base(marca, modelo, año)
        {
            NumeroPuertas = numeroPuertas;
            Color = color;
            VelocidadActual = 0.0;
        }

        //Sobre escritura de métodos de la clase Padre
        public override void Conducir()
        {
            base.Conducir();
            Console.WriteLine("El carro está en movimiento.");
        }

        public void Acelerar(double cantidad)
        {
            VelocidadActual += cantidad;
            Console.WriteLine($"El carro aceleró a {cantidad} km/h. Velocidad actual: {VelocidadActual} km/h");
        }

        public void Frenar(double cantidad)
        {
            VelocidadActual -= cantidad;
            Console.WriteLine($"El carro frenó a {cantidad} km/h. Velocidad actual: {VelocidadActual} km/h");
        }
        // Método para mamejo de Motor
        public void EncenderMotor()
        {
            MotorEncendido = true;
            Console.WriteLine("Motor encendido.");
        }

      
        public void ApagarMotor()
        {
            MotorEncendido = false;
            Console.WriteLine("Motor apagado.");
        }
    }
}
