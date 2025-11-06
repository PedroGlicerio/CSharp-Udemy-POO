using System.Globalization;

namespace Exercicio03.Entities {
    internal class ItemPedido {

        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto Produto { get; set; }

        public ItemPedido(int quantidade, double preco, Produto produto) {

            Quantidade = quantidade;
            Preco = preco;
            Produto = produto;
        }

        public double SubTotal() {

            return Preco * Quantidade;
        }

        public override string ToString() {

            return $"{Produto.Nome}, R${Preco}, Quantidade: {Quantidade}, Subtotal: R${SubTotal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
