using System.Globalization;

namespace Exercicio02.Entities {
    internal class Produto {

        public int Id { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(int id, string nome, double preco, int quantidade) {

            Id = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public void AdicionarUnidades(int quantidade) {

            Quantidade += quantidade;
        }

        public void RemoverUnidades(int quantidade) {

            Quantidade -= quantidade;
        }

        public double ValorTotalEmEstoque() {

            return Preco * Quantidade;
        }

        public override string ToString() {
            return $"{Id}, {Nome}, Preço: R${Preco.ToString("F2", CultureInfo.InvariantCulture)}, Quantidade: {Quantidade}, Total: R${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
