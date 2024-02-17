
using System;

namespace Sesion_2
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Ingresa tu nombre!");
            //String nombre = Console.ReadLine();
            // Console.WriteLine("Hello " + nombre);

            Pizarra Pizarron = new Pizarra("Blanco", 1.5, 3.1);
            Pizarron.Escribir("Hola estudiantes");

            Console.WriteLine(Pizarron.GetContenido());

        }
    }
}