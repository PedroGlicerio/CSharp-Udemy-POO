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
                    break;
                case 2:
                    return 4.50 * Quantidade;
                    break;
                case 3:
                    return 5 * Quantidade;
                    break;
                case 4:
                    return 2 * Quantidade;
                    break;
                case 5:
                    return 1 * Quantidade;
                    break;
                default:
                    return 0;
                    break;
            }
        }

        public override string ToString() {
            return $"Valor Total: R${valorLanche():f2}";
        }
    }
}
