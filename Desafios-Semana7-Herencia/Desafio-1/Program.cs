
using System;

namespace Desafio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora Calc= new Calculadora("Casio","Fx-82");
            Calc_Cientifica calc_ = new Calc_Cientifica("Casio", "Fx-82");

            Console.WriteLine("Datos de la Calculadora");
            Console.WriteLine($"Marca: {Calc.Marca}");
            Console.WriteLine($"Modelo: {Calc.Serie}");

            Console.WriteLine($"Sumar: {Calc.Sumar(4,8)}");
            Console.WriteLine($"Restar: {Calc.Restar(9,5)}");
            Console.WriteLine($"Multiplicar: {Calc.Multiplicar(4,9)}");
            Console.WriteLine($"Dividir: {Calc.Dividir(12,3)}");
            Console.WriteLine($"Potencia: {calc_.Potencia(2, 3)}");
            Console.WriteLine($"Raiz: {calc_.Raiz(16,2)}");
            Console.WriteLine($"Modulo: {calc_.Modulo(8, 2)}");
            Console.WriteLine($"Logaritmo: {calc_.Logaritmo(4,2)}");

        }
    }
}