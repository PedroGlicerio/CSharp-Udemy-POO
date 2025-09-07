using System;

namespace Exercicio02.Entities {
    internal class Circulo {

        public double Raio { get; set; }

        public Circulo(double raio) {

            Raio = raio;
        }

        public double areaCirculo() {

            double pi = 3.14159;
            return pi * Math.Pow(Raio, 2);
        }

        public override string ToString() {
            return $"Área: {areaCirculo():f4}";
        }
    }
}
