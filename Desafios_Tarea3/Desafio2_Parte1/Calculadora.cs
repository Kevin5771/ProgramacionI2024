using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio2_Parte1
{
    internal class Calculadora
    {

        public int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Restar(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Dividir(int num1, int num2)
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                Console.WriteLine("Error: División por cero.");
                return 0;
            }
        }
    }
}
