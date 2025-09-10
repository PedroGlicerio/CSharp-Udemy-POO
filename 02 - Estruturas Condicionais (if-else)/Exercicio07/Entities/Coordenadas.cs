using System;

namespace Exercicio07.Entities {
    internal class Coordenadas {

        public double X { get; set; }
        public double Y { get; set; }
        public Coordenadas(double x, double y) {

            X = x;
            Y = y;
        }

        public string Posicao() {

            if (X == 0 && Y == 0) {
                return "Origem";
            } else if (X == 0.0) {
                return ("Eixo Y");
            } else if (Y == 0.0) {
                return ("Eixo X");
            } else if (X > 0 && Y > 0) {
                return "Q1";
            } else if (X < 0 && Y > 0) {
                return "Q2";
            } else if (X < 0 && Y < 0) {
                return "Q3";
            } else {
                return "Q4";
            }
        }

        public override string ToString() {
            return $"{Posicao()}";
        }
    }
}
