using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcaial
{
    public class Cuenta_Bancaria
    {

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
            this.saldo = 1000;
        }

        /// <summary>
        /// Método para depositos en el sistema
        /// </summary>
        /// <param name="cantidad"></param>
        public void funcDepositar(double cantidad)
        {
            saldo += cantidad;
            Console.WriteLine("Se depositó Q" + cantidad + " en la cuenta " + numeroCuenta);
        }

        /// <summary>
        /// Retiros de usuario en su cuenta
        /// </summary>
        /// <param name="cantidad"></param>
        public void funcRetirar(double cantidad)
        {
            saldo -= cantidad;
            Console.WriteLine("Se retiro Q" + cantidad + "en la cuenta " + numeroCuenta);

        }
        /// <summary>
        /// Consultas de Saldos en las centas registradas
        /// </summary>
        public void Consultar()
        {
            Console.WriteLine("El saldo Actual de la cuenta es: Q." + saldo + "para la cuenta: " + numeroCuenta);
        }
    }
}
