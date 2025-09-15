using System;

namespace Exercicio06.Entities {
    internal class Divisor {

        public int Numero { get; set; }

        public Divisor(int numero) {

            Numero = numero;
        }

        public void numDiv() {

            for (int i = 1; i <= Numero; i++) {
                if (Numero % i == 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
