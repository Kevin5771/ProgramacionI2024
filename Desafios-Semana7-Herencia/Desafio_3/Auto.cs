using System;
using System.Collections.Generic;

namespace Desafio_3
{
    public class Auto
    {
        // Propiedades
        public int HP { get; set; }
        public string Color { get; set; }
        public List<string> HistoriaReparaciones { get; } = new List<string>();

        // Constructor parametrizado
        public Auto(int hp, string color)
        {
            HP = hp;
            Color = color;
        }

        // Métodos
        public void MostrarDetalles()
        {
            Console.WriteLine("HP: {0} - Color: {1}", HP, Color);
        }

        public virtual void Reparar()
        {
            Console.WriteLine("El auto ya está reparado");
            RegistrarReparacion();
        }

        public void HistoriaDeReparaciones()
        {
            Console.WriteLine("Historia de reparaciones:");
            foreach (string reparacion in HistoriaReparaciones)
            {
                Console.WriteLine(reparacion);
            }
        }

        private void RegistrarReparacion()
        {
            HistoriaReparaciones.Add("Reparación realizada el " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
        }
    }
}
