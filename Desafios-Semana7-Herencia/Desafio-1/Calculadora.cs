using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    public class Calculadora
    {

        public string Marca { get; set; }
        public string Serie { get; set; }

        public Calculadora(string marca, string serie) { 
            Marca = marca;
            Serie = serie;
        }

        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public int Restar(int a, int b)
        {
            return a - b;
        }


        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public double Dividir(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("El divisor no puede ser cero.");
            }
            return (double)a / b;
        }
    }
}

