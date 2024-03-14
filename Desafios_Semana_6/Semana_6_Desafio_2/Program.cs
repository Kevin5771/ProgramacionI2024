
using System;

namespace Desafios_Semana_6
{
    class Program
    {
        /* 
        Escribe un programa que solicite al usuario que ingrese un número entero positivo y determine si es un número primo
        o no utilizando un loop "for". Si el número es primo, 
        el programa debe imprimir un mensaje indicando que es primo y salir del loop utilizando "break" 
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número entero: ");
            String var = Console.ReadLine();
            byte num = byte.Parse(var);


            bool NumPrimo = true;

            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    NumPrimo = false;
                    break;
                }
                if (NumPrimo && num >1) {

                    Console.WriteLine($"El número {num} es primo");
                }
                else {
                    Console.WriteLine($"El número {num} no es primo");
                }

                }

            }

        }
    }
