using System;
using System.Security.Cryptography;

namespace Exercicio01.Entities {
    internal class Pessoa {

        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa() {
        }
        public void pessoaVelha(Pessoa p1, Pessoa p2) {

            if (p1.Idade > p2.Idade) {
                Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
            } else {
                Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
            }
        }
    }
}
