using System.Globalization;

namespace Exercicio01.Entities {
    internal class Funcionario {

        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorPorHora { get; set; }

        public Funcionario(string nome, int horas, double valorPorHora) {

            Nome = nome;
            Horas = horas;
            ValorPorHora = valorPorHora;
        }

        public virtual double Pagamento() {

            return Horas * ValorPorHora;
        }

        public override string ToString() {

            return $"{Nome} - R${Pagamento().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
