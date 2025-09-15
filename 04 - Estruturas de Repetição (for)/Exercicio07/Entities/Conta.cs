using System;

namespace Exercicio07.Entities {
    internal class Conta {

        public int Numero { get; set; }

        public Conta(int numero) {

            Numero = numero;

        }

        public void numConta() {

            Console.WriteLine();
            for (int i = 1; i <= Numero; i++) {
                Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            }
        }
    }
}
