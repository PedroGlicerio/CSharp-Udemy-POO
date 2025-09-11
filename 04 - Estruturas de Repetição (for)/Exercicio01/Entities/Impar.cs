using System;
using System.Runtime.InteropServices.Marshalling;

namespace Exercicio01.Entities {
    internal class Impar {

        public int Numero { get; set; }

        public void numerosImpares() {

            Console.Write("Digite um número: ");
            Numero = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine($"Números Impares de 1 a {Numero}:");
            for (int i = 1; i <= Numero; i += 2) {
                Console.WriteLine(i);
            }
        }
    }
}
