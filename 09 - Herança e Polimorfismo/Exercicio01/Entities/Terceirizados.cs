namespace Exercicio01.Entities {
    internal class Terceirizados : Funcionario {

        public double DespesaAdicional { get; set; }

        public Terceirizados(string nome, int horas, double valorPorHora, double despesaAdicional) : base (nome, horas, valorPorHora) {

            DespesaAdicional = despesaAdicional;
        }

        public override double Pagamento() {

            return base.Pagamento() + 1.1 * DespesaAdicional;
        }
    }
}
