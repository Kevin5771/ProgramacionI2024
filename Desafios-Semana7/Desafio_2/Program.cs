

using System;
using System.Runtime.CompilerServices;

namespace Desafio_2
{
    class Program
    {
        public static int[][] Calculadora(int[][] compras)
        {
            // Llevaremos el control del numero de compras
            int[][] descuentos = new int[compras.Length][];

            for (int i = 0; i < compras.Length; i++)
            {
                int totalCompras = 0;

                foreach (int compra in compras[i])
                {
                    totalCompras += compra;
                }

                double descuento = 0;
                if (totalCompras >= 100 && totalCompras <= 1000)
                {
                    descuento = 0.1 * totalCompras;

                }
                else if (totalCompras > 1000)
                {
                    descuento = 0.2 * totalCompras;
                }

                int totalConDescuentos = totalCompras - (int)descuento;

                // Almacenamos tanto el total de compras como el descuento
                descuentos[i] = new int[] { totalCompras, totalConDescuentos };

            }
            return descuentos;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!!!");
            int[][] comprasClientes = new int[][] {
                new int[] {50, 120, 300, 800, 1500},  // Cliente 1
                new int[] {200, 150, 250, 600, 700},  // Cliente 2
                new int[] {80, 90, 110, 120, 130},    // Cliente 3
                new int[] {1000, 1200, 900, 1100, 950},// Cliente 4
                new int[] {2000, 3000, 1500, 800, 600} // Cliente 5
            };

            int[][] descuentosClientes = Calculadora(comprasClientes);

            for (int i = 0; i < descuentosClientes.Length; i++)
            {
                int totalCompra = descuentosClientes[i][0];
                int totalDescuento = descuentosClientes[i][1];

                Console.WriteLine($"Cliente {i + 1}: Total compra: ${totalCompra}, Total con descuento: ${totalDescuento}");

            }

        }
    }
}
