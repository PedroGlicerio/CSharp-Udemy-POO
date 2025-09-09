using System;

namespace Exercicio06.Entities {
    internal class Figura {

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Figura(double a, double b, double c) {

            A = a;
            B = b;
            C = c;
        }

        public double areaTriangulo() {

            return (A * C) / 2;
        }

        public double areaCirculo() {

            double pi = 3.14159;
            return pi * Math.Pow(C, 2);
        }

        public double areaTrapezio() {

            return ((A + B) * C) / 2;
        }

        public double areaQuadrado() {

            return Math.Pow(B, 2);
        }

        public double areaRetangulo() {

            return A * B;
        }

        public override string ToString() {
            return $"TRIANGULO: {areaTriangulo():f3}\nCIRCULO: {areaCirculo():f3}\nTRAPEZIO: {areaTrapezio():f3}\nQUADRADO: {areaQuadrado():f3}\nRETANGULO: {areaRetangulo():f3}";
        }
    }
}
