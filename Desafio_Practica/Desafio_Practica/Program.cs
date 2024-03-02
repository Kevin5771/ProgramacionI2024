
using System;
using System.ComponentModel.Design;

namespace Desafio_Practica
{
    class Program
    {

        /* Crea un programa en C# que simule un sistema de gestión de cuentas bancarias. Debe permitir al usuario 
         * realizar las siguientes operaciones:

                Crear una cuenta bancaria.
                Depositar dinero en una cuenta existente.
                Retirar dinero de una cuenta existente.
                Consultar el saldo de una cuenta existente.
                Salir del programa.
                Cada cuenta bancaria debe tener un número de cuenta único,
                un nombre de titular y un saldo inicial de 0. El programa debe permitir al usuario 
                seleccionar estas operaciones mediante un menú.
        */

        static void Main(string[] args)
        {
            Cuenta_Bancaria[] cuentas = new Cuenta_Bancaria[10]; // Suponemos un máximo de 10 cuentas
            int contadorCuentas = 0;
            bool Active = true;

            while (Active == true ) {

                Console.WriteLine("Bienvenido al sistema de gestión de cuentas bancarias");
                Console.WriteLine("1. Crear una cuenta bancaria");
                Console.WriteLine("2. Depositar dinero");
                Console.WriteLine("3. Retirar dinero");
                Console.WriteLine("4. Consultar saldo");
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
                        int cuentaDeposito = int.Parse(dateCuenta1);
                        Console.Write("Ingrese la cantidad a depositar: ");
                        double cantidadDeposito = double.Parse(Console.ReadLine());
                        foreach (var cuenta in cuentas)
                        {
                            if (cuenta != null && cuentaDeposito == cuenta.numeroCuenta)
                            {
                                cuenta.Depositar(cantidadDeposito);
                                Console.WriteLine("Deposito Exitoso");
                                break;
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el número de cuenta: ");
                        string dateCuenta2 = Console.ReadLine();
                        int cuentaRetiro= int.Parse(dateCuenta2);
                        Console.Write("Ingrese la cantidad a retirar: ");
                        double cantidadRetiro = double.Parse(Console.ReadLine());
                        foreach (var cuenta in cuentas)
                        {
                            if (cuenta != null && cuentaRetiro == cuenta.numeroCuenta)
                            {
                                cuenta.Retirar(cantidadRetiro);
                                Console.WriteLine("Retiro exitoso :)");
                            }
                            
                        }
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el número de cuenta: ");
                        string dateCuenta3 = Console.ReadLine();
                        int cuentaSaldo = int.Parse(dateCuenta3);
                        foreach (var cuenta in cuentas)
                        {
                            if(cuenta != null && cuentaSaldo == cuenta.numeroCuenta)
                            {
                                cuenta.Consultar();
                                Console.WriteLine(":)");
                            }

                        }
                        break;
                    case 5:
                        Console.WriteLine("Gracias por usar el sistema. ¡Hasta luego!");
                        Active = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }


           
            }

        }
    }
}