
using System;

namespace Desafios_Semana_6
{
    class Program
    {

        /* 
         Escribe un programa que solicite al usuario que ingrese un número entero positivo y muestre todos los números 
        pares desde 1 hasta el número ingresado. 
        Si el número actual no es par, el programa debe continuar con el siguiente número sin imprimir nada.
         */

        static void mensaje()
        {
            Console.WriteLine("Bienvenido al Programa :)");
            Console.WriteLine("Calculador de números pares");
        }
        static void Main(string[] args)
        {
            mensaje();
            // Inicio
            Console.WriteLine("Ingresa un entero positivo:");
            String var = Console.ReadLine();
            byte num = byte.Parse(var);

            Console.WriteLine($"Números pares hasta {num}");

            for (int i = 0; i <= num; i++)
            {
                if (i %2 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
    }
}