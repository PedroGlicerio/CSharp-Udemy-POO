using System;

namespace Exercicio02.Entities {
    internal class Comparacao {

        public int Numero { get; set; }

        public Comparacao(int numero) {

            Numero = numero;
        }

        public string numeroParOuImpar() {

            if (Numero % 2 == 0) {
                return "PAR";
            } else {
                return "IMPAR";
            }
        }
        public override string ToString() {
            return $"O número {Numero} é: {numeroParOuImpar()}";
        }
    }
}
