
using System;
using System.Globalization;

namespace Desafio2_Parte1
{

    // Desafio 2

    class Program { 

        static void Main(string[] args)
        {

            /* 
            Crear una clase que contenga 4 métodos que realicen las operaciones básicas (Sumar, Restar, Multiplicar, Dividir), 
            debe pedir como parámetro dos números de tipo int y retornar un valor del mismo tipo. 

            Debe invocar los 4 métodos desde el método main.*/


            Console.WriteLine("-------calculadora-------");

            Console.WriteLine("Ingrese el Primer Número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el Segundo Número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Calculadora calculadora = new Calculadora();

            Console.WriteLine("Suma: " + calculadora.Sumar(numero1,numero2));
            Console.WriteLine("Resta: " + calculadora.Restar(numero1,numero2));
            Console.WriteLine("Multiplicación: "+ calculadora.Multiplicar(numero1, numero2));
            Console.WriteLine("División: "+ calculadora.Dividir(numero1,numero2));



        }
    }
}

