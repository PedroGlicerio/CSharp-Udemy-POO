using Exercicio01.Entities.Enums;

namespace Exercicio01.Entities {
    internal class Circulo : Figura {

        public double Raio { get; set; }

        public Circulo (double raio, Cor cor) : base (cor) {

            Raio = raio;
        }

        public override double Area() {

            return Math.PI * Math.Pow(Raio, 2);
        }
    }
}
