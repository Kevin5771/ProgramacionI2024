using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Practica
{
    public class Cuenta_Bancaria {  

    public int numeroCuenta;
    private string nombreTitular;
    private double saldo;


        /// <summary>
        /// Nuestro Constructor con Datos de Cuenta de Ahorro
        /// </summary>
        /// <param name="numeroCuenta"></param>
        /// <param name="nombreTitular"></param>
    public Cuenta_Bancaria(int numeroCuenta, string nombreTitular)
    {
        this.numeroCuenta = numeroCuenta;
        this.nombreTitular = nombreTitular;
        this.saldo = 0;
    }

        /// <summary>
        /// Método para depositos en el sistema
        /// </summary>
        /// <param name="cantidad"></param>
        public void Depositar(double cantidad)
        {
            saldo += cantidad;
            Console.WriteLine("Se depositó $" + cantidad + " en la cuenta " + numeroCuenta);
        }

        /// <summary>
        /// Retiros en nuestro sistema
        /// </summary>
        /// <param name="cantidad"></param>
        public void Retirar(double cantidad) {
            saldo -= cantidad;
            Console.WriteLine("Se retiro $" + cantidad + "en la cuenta " + numeroCuenta);

        }
        /// <summary>
        /// Consultas de Saldos
        /// </summary>
        public void Consultar ()
        {
            Console.WriteLine("El saldo Actual de la cuenta es: $ " + saldo + "para la cuenta: " + numeroCuenta);
        }
    }
}
