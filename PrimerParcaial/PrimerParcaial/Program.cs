

using PrimerParcaial;
using System;

namespace CajeroAutomatico
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta_Bancaria[] cuentas = new Cuenta_Bancaria[10]; // Suponemos un máximo de 10 cuentas almacenadas en un Array
            int contadorCuentas = 0;
            bool Active = true;

            while (Active == true)
            {

                Console.WriteLine("Bienvenido Al Cajero Automático");
                Console.WriteLine("1. Crear una cuenta bancaria");
                Console.WriteLine("2. Depositar dinero a la cuenta");
                Console.WriteLine("3. Retirar dinero de la cuenta");
                Console.WriteLine("4. Verificar saldo disponible en la cuenta");
                Console.WriteLine("5. Salir");

                Console.Write("Seleccione una opción: ");
                byte op = byte.Parse(Console.ReadLine());


                switch (op)
                {
                    case 1:
                        Console.Write("Ingrese el número de cuenta: ");
                        string dateCuenta = Console.ReadLine();
                        int numeroCuenta = int.Parse(dateCuenta);
                        Console.Write("Ingrese el nombre del titular: ");
                        string nombreTitular = Console.ReadLine();
                        cuentas[contadorCuentas] = new Cuenta_Bancaria(numeroCuenta, nombreTitular);
                        contadorCuentas++;
                        break;
                    case 2:
                        Console.Write("Ingrese el número de cuenta: ");
                        string dateCuenta1 = Console.ReadLine();
                        int numeroCuenta1 = int.Parse(dateCuenta1);
                        Console.WriteLine("Ingrese el Monto del Deposito: ");
                        string cantidad = Console.ReadLine();
                        int cantidaDeposito = int.Parse(cantidad);

                        foreach (var cuenta in cuentas)
                        {
                            if (cuenta != null && numeroCuenta1 == cuenta.numeroCuenta)
                            {
                                cuenta.funcDepositar(cantidaDeposito);

                            }
                        }
                        break;
                    case 3:
                        Console.Write("Ingrese el número de cuenta: ");
                        string dateCuenta2 = Console.ReadLine();
                        int numeroCuenta2 = int.Parse(dateCuenta2);
                        Console.WriteLine("Ingrese el Monto del Retiro: ");
                        string cantidad1 = Console.ReadLine();
                        int cantidadRetiro = int.Parse(cantidad1);


                        foreach (var cuenta in cuentas)
                        {
                            if (cuenta != null && numeroCuenta2 == cuenta.numeroCuenta)
                            {
                                cuenta.funcRetirar(cantidadRetiro);

                            }
                        }
                        break;

                    case 4:
                        Console.Write("Ingrese el número de cuenta: ");
                        string dateCuenta3 = Console.ReadLine();
                        int numeroCuenta3 = int.Parse(dateCuenta3);

                        foreach (var cuenta in cuentas)
                        {
                            if (cuenta != null && numeroCuenta3 == cuenta.numeroCuenta)
                                cuenta.Consultar();
                        }

                        break;

                    case 5:
                        Console.WriteLine("Gracias por Usar Nuestro Cajero Automatico :)");
                        Active = false;
                        break;
                    default:
                        Console.WriteLine("Opción Invalida");
                        break;
                }



            }
        }
    }
}
