using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    public class Calc_Cientifica: Calculadora
    {

        public Calc_Cientifica(string marca, string serie) : base(marca, serie)
        {
            
        }
        public double Potencia(double baseNum, double exponente)
        {
            return Math.Pow(baseNum, exponente);
        }

        public double Raiz(double numero, double indice)
        {

            return Math.Pow(numero, 1 / indice);
        }

        public double Modulo(double dividendo, double divisor)
        {
            return dividendo % divisor;
        }

        public double Logaritmo(double numero, double baseNum = 10)
        {

            return Math.Log(numero, baseNum);
        }
    }
}
