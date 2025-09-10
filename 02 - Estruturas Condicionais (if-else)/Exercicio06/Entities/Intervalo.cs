using System;

namespace Exercicio06.Entities {
    internal class Intervalo {

        public double Numero { get; set; }

        public Intervalo(double numero) {

            Numero = numero;
        }

        public string intervaloNumero() {

            if (Numero < 0 || Numero > 100) {
                return "Fora de Intervalo";
            } else if (Numero >= 0 && Numero <= 25) {
                return "Intervalo [0,25]";
            } else if (Numero <= 50) {
                return "Intervalo (25,50]";
            } else if (Numero <= 75) {
                return "Intervalo (50,75]";
            } else {
                return "Intervalo (75,100]";
            }
        }

        public override string ToString() {
            return $"{intervaloNumero()}";
        }
    }
}
