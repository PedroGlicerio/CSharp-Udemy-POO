using System;

namespace Exercicio02.Entities {
    internal class Verificacao {

        public int X { get; set; }
        public int Y { get; set; }

        public Verificacao() {
        }

        public void verificacaoCoord() {

            Console.Write("Digite duas coordenadas [X/Y]: ");
            string[] coord = Console.ReadLine().Split(" ");
            X = int.Parse(coord[0]);
            Y = int.Parse(coord[1]);

            while (X != 0 && Y != 0) {

                if (X > 0 && Y > 0) {
                    Console.WriteLine();
                    Console.WriteLine("Primeiro");
                } else if (X < 0 && Y > 0) {
                    Console.WriteLine();
                    Console.WriteLine("Segundo");
                } else if (X < 0 && Y < 0) {
                    Console.WriteLine();
                    Console.WriteLine("Terceiro");
                } else {
                    Console.WriteLine();
                    Console.WriteLine("Quarto");
                }

                Console.WriteLine();
                Console.Write("Digite duas coordenadas novamente [X/Y]: ");
                coord = Console.ReadLine().Split(" ");
                X = int.Parse(coord[0]);
                Y = int.Parse(coord[1]);
            }

            Console.WriteLine();
        }
    }
}
