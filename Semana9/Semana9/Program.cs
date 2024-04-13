
using System;
using System.Security.Cryptography.X509Certificates;
using ModificadorAcceso;

namespace Semana9
{
    internal struct Juego()
    {
        public string name;
        public string Desarrollador;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!!");

            Demostracion Clase = new Demostracion();

            Console.WriteLine(Clase.ObtenerEdad());

            ClaseHeredada objClassHeredada = new ClaseHeredada();
            objClassHeredada.metProtectedHeredado();

            Juego juego;

            juego.name = "Zelda";
            juego.Desarrollador = "Nintendo";

            Console.WriteLine("{0}-{1}", juego.name, juego.Desarrollador);


            //Console.WriteLine(Clase.EjemploEnum(DateTime.Now.DayOfWeek());
  
                }

        public static string getChar(int ascii)
        { 
            return ((char)ascii).ToString();

        }

        public static string getRandomChar()
        {
            Random rnd = new Random();
            return getChar(rnd.Next(97,122));
        }

        public string generarAleatorio (int digitos)
        {
            string id = "";

            for (int i = 0; i < digitos; i++)
            {
                id += digitos;
            }
        }
    }
}