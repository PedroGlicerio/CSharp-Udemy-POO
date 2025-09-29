using System;
using System.Globalization;

namespace Exercicio05.Entities {
    internal class Funcionario {

        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public Funcionario(string nome, double salarioBruto, double imposto) {

            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
        }

        public double SalarioLiquido() {

            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem) {

            SalarioBruto += porcentagem / 100 * SalarioBruto;
        }

        public override string ToString() {
            return $"{Nome}, R${SalarioLiquido().ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
