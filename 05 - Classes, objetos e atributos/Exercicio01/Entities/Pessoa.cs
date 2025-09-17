using System;

namespace Exercicio01.Entities {
    internal class Pessoa {

        public int Numero { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }


        public Pessoa(int numero) {

            Numero = numero;
        }
        public Pessoa(string nome, int idade) {

            Nome = nome;
            Idade = idade;
        }

        public void pessoaMaisVelha() {

            List<Pessoa> pessoas = new List<Pessoa>();

            for  (int i = 0; i < Numero; i++) {

                Console.WriteLine($"Dados da {i + 1}° pessoa:");
                Console.Write("Nome: ");
                Nome = Console.ReadLine();
                Console.Write("Idade: ");
                Idade = int.Parse(Console.ReadLine());

                pessoas.Add(new Pessoa(Nome, Idade));
                Console.WriteLine();
            }

            Pessoa maisVelha = pessoas[0];
            foreach(Pessoa p in pessoas) {
                if (p.Idade > maisVelha.Idade) {
                    maisVelha = p;
                }
            }

            Console.WriteLine($"A pessoa mais velha é {maisVelha.Nome} com {maisVelha.Idade} anos");
        }
    }
}
