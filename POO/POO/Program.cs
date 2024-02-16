using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Práctica POO \n");

            Carro miCarro = new Carro("Toyota", "Hilux", 2023, 4, "Blanco");

            Console.WriteLine("Datos del vehiculo");
            Console.WriteLine($"Marca: {miCarro.Marca},  \n" +
                $"Modelo: {miCarro.Modelo} \nAño: {miCarro.Año} \n" +
                $"Puertas: {miCarro.NumeroPuertas} \n" +
                $"Color: {miCarro.Color}");

            Console.WriteLine("\n");

            miCarro.EncenderMotor();
            miCarro.Conducir();
            miCarro.Acelerar(60);
            miCarro.Frenar(20);

        }
    }
}
