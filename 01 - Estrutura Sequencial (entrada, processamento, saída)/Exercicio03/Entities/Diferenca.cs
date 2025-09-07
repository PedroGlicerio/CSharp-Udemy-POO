using System;

namespace Exercicio03.Entities {
    internal class Diferenca {

        public int Valor1 { get; set; }
        public int Valor2 { get; set; }
        public int Valor3 { get; set; }
        public int Valor4 { get; set; }

        public Diferenca(int valor1, int valor2, int valor3, int valor4) {

            Valor1 = valor1;
            Valor2 = valor2;
            Valor3 = valor3;
            Valor4 = valor4;
        }

        public double Calculo() {

            return (Valor1 * Valor2 - Valor3 * Valor4);         
        }

        public override string ToString() {
            return $"Diferença: {Calculo()}";
        }
    }
}
