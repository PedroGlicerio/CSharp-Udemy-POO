using System;

namespace Exercicio01.Entities {
    internal class Comparacao {

        public int Numero { get; set; }

        public Comparacao(int numero) {

            Numero = numero;
        }

        public string numeroPositivoOuNegativo() {

            if (Numero >= 0) {
                return "POSITIVO!"; 
            } else {
                return "NEGATIVO!";
            }
        }

        public override string ToString() {
            return $"O número {Numero} é: {numeroPositivoOuNegativo()}";
        }
    }
}
