using System;

namespace Exercicio05.Entities {
    internal class Fatorial {

        public int Numero { get; set; }

        public Fatorial(int numero) {
            Numero = numero;
        }

        public void contaFat() {

            int fat = 1;
            for (int i = 1; i <= Numero; i++) {
                fat *= i;
                
            }

            Console.WriteLine($"O fatorial de {Numero} é: {fat}");
        }
    }
}
