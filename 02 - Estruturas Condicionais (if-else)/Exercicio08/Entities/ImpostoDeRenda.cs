using System;

namespace Exercicio08.Entities {
    internal class ImpostoDeRenda {

        public double Salario { get; set; }

        public ImpostoDeRenda(double salario) {

            Salario = salario;
        }

        double imposto = 0;
        public void Renda(double salario) {

            if (Salario <= 2000.0) {
                imposto = 0.0;
            } else if (Salario <= 3000.0) {
                imposto = (Salario - 2000.0) * 0.08;
            } else if (Salario <= 4500.0) {
                imposto = (Salario - 3000.0) * 0.18 + 1000.0 * 0.08;
            } else {
                imposto = (Salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }
        }

        public override string ToString() {
            if (imposto == 0.0) {
                return "Isento";
            } else {
                return $"R$ {imposto:f2}";
            }
        }
    }
}
