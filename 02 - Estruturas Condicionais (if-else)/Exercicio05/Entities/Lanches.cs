using System;

namespace Exercicio05.Entities {
    internal class Lanches {

        public int Codigo { get; set; }
        public int Quantidade { get; set; }

        public Lanches() {
        }

        public double valorLanche() {

            switch (Codigo) {
                case 1:
                    return 4 * Quantidade;
                case 2:
                    return 4.50 * Quantidade;
                case 3:
                    return 5 * Quantidade;
                case 4:
                    return 2 * Quantidade;
                case 5:
                    return 1 * Quantidade;
                default:
                    return 0;
            }
        }

        public override string ToString() {
            return $"Valor Total: R${valorLanche():f2}";
        }
    }
}
