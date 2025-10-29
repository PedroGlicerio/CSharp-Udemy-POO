using System.Globalization;

namespace Exercicio02.Entities {
    internal class ProdutoUsado : Produto {

        public DateTime DataFabricacao { get; set; }

        public ProdutoUsado(string nome, double preco, DateTime dataFabricacao) :base (nome, preco) {

            DataFabricacao = dataFabricacao;
        }

        public override string TagPreco() {

            return $"{Nome} (Usado) - R${Preco.ToString("F2", CultureInfo.InvariantCulture)} (Data de Fabricação: {DataFabricacao.ToString("dd/MM/yyyy")})";
        }
    }
}
