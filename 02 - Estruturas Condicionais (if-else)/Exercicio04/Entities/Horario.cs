using System;


namespace Exercicio04.Entities {
    internal class Horario {

        public int A { get; set; }
        public int B { get; set; }

        public Horario() {
        }

        public int duracaoJogo() {

            int duracaoMax = 24;
            if (A < B) {
                return B - A;
            } else {
                return duracaoMax - A + B;
            }
        }

        public override string ToString() {
            return $"O JOGO DUROU {duracaoJogo()} HORA(S)";
        }
    }
}
