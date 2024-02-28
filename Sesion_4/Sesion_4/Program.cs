using System;

namespace Sesion_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!!!");

            Persona persona = new Persona("Marco", 29);
            // Console.WriteLine(persona.Saludar("Juan"));


            static void Excetiones (){
                try
                {
                    Calculadora calc = new Calculadora();
                    Console.WriteLine("Ingrese el primer Numero");
                    float n1 = float.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el Segundo Numero");
                    float n2 = float.Parse(Console.ReadLine());

                    // Se imprime el resultado de la suma
                    Console.WriteLine(calc.Sumar(n1, n2));
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine("Algo Salio Mal");
                    Console.Error.WriteLine(ex.Message);
                    Console.Error.WriteLine(ex.GetType().Name);
                }
                finally
                {
                    Console.WriteLine("Esto siempre se Ejecuta");
                }

            }
 


            // Se declara la función VerificarEdad
            static void VerificarEdad(int edad)
            {
                if (edad < 18)
                {
                    Console.WriteLine("Eres menor de edad");
                }
                else if (edad >= 18 && edad < 100)
                {
                    Console.WriteLine("Adulto");
                }
            }

            //Uso de switch

            static void verifEdades()
            {
                bool confirmar = true;

                while (confirmar == true)
                {
                    Console.WriteLine("MENU");
                    Console.WriteLine("1. Saludar");
                    Console.WriteLine("2. Sumar");
                    Console.WriteLine("Ingrese su opción:");
                    string option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            Console.WriteLine("¡Hola!");
                            break;
                        case "2":
                            Console.WriteLine("Ingrese el primer número:");
                            float n1 = float.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo número:");
                            float n2 = float.Parse(Console.ReadLine());


                            if (n1 > 0 && n2 > 0)
                            {
                                float resultado = n1 + n2;
                                Console.WriteLine($"La suma de {n1} y {n2} es: {resultado}");
                            }
                            else
                            {
                                Console.WriteLine("Error al ingresar el segundo número.");
                            }
                            break;
                        default:
                            Console.WriteLine("Opción no reconocida.");
                            break;
                    }
                    //string.IsNullOrEmpty (Para Validaciones
                    //)
                    Console.WriteLine("¿Desea continuar? (s/n)");
                    string continuar = Console.ReadLine();
                    if (continuar != "s")
                    {
                        confirmar = false;
                        Console.WriteLine("saliendo del programa");
                    }
                }
            }

            verifEdades();

        }
    }
}
