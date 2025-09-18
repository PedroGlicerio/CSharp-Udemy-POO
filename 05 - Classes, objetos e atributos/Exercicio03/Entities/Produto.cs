using System;
using System.Globalization;

namespace Exercicio03.Entities {
    internal class Produto {

        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto(string nome, double preco, int quantidade) {

            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque() {

            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) {

            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {

            Quantidade -= quantidade;
        }

        public override string ToString() {
            return $"Dados do produtos: {Nome}, R${Preco.ToString("f2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: R$ {ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}
