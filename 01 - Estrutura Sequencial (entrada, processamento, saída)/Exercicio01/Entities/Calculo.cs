using System;
using System.Reflection.Metadata.Ecma335;

namespace Exe001.Entities {
    internal class Calculo {

        public int Valor1 { get; set; }
        public int Valor2 { get; set; }

        public Calculo(int valor1, int valor2) {

            Valor1 = valor1;
            Valor2 = valor2;
        }

        public int Soma() {

            return Valor1 + Valor2;
        }

        public override string ToString() {
            return $"Resultado da soma: {Soma()}";
        }
    }
}
