using System;

namespace Exercicio03.Entities {
    internal class Verificacao {

        public int A { get; set; }
        public int B { get; set; }

        public Verificacao() {
        }

        public Verificacao(int a, int b) {

            A = a;
            B = b;
        }

        public string numerosMultiplos() {

            if (A % B == 0 || B % A == 0) {
                return "São multiplos";
            } else {
                return "Não são multiplos";
            }
        }
    }
}
