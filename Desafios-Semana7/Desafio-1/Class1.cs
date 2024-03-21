using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_1
{
    public class Class1
    {

        public char[,] tablero;

        public Class1() {
            tablero = new char[3, 3];
            Iniciar_tablero();
        }

        private void Iniciar_tablero()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tablero[i, j] = ' ';
                }
            }
        }

        public void Dibujar_Tablero() {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tablero[i, j]);
                    if (j < 2)
                    {
                        Console.Write(" | ");
                    }
                }
                Console.WriteLine();
                if (i < 2) {
                    Console.WriteLine("----------");
                }

            }
        }


    }
}
