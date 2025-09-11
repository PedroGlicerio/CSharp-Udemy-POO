using System;

namespace Exercicio02.Entities {
    internal class Intervalo {

        public int Numero { get; set; }

        public Intervalo(int numero) {

            Numero = numero;
        }
        public void dentroIntervalo() {

            int dentro = 0;
            int fora = 0;

            for (int i = 0; i < Numero; i++) {

                Console.Write("Digite um valor: ");
                int n = int.Parse(Console.ReadLine());

                if (n >= 10 && n <= 20) {
                    dentro++;
                } else {
                    fora++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Total de valores dentro e fora do intervalo [10,20]:");
            Console.WriteLine($"{dentro} dentro");
            Console.WriteLine($"{fora} fora");
        }
    }
}
