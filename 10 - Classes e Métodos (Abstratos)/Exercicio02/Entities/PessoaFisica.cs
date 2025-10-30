namespace Exercicio02.Entities {
    internal class PessoaFisica : Contribuinte {

        public double GastoComSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastoComSaude) : base(nome, rendaAnual) {

            GastoComSaude = gastoComSaude;
        }
        public override double Taxa() {

            if (RendaAnual < 20000) {

                return RendaAnual * 0.15 - GastoComSaude * 0.5;

            } else {

                return RendaAnual * 0.25 - GastoComSaude * 0.5;
            }
        }
    }
}

