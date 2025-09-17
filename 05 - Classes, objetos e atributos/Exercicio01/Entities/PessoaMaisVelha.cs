using System;

namespace Exercicio01.Entities {
    internal class PessoaMaisVelha {

        public static string pessoaVelha(Pessoa p1, Pessoa p2) {

            if (p1.Idade > p2.Idade) {
                return $"Pessoa mais velha: {p1.Nome}";  
            } else {
                return $"Pessoa mais velha: {p2.Nome}";
            }
        }
    }
}
