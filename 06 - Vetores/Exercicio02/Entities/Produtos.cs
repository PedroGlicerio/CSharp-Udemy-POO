namespace Teste.Entities {
    internal class Produtos {

        public string Nome { get; set; }
        public double Preco { get; private set; }

        public Produtos(string nome, double preco) {

            Nome = nome;
            Preco = preco;
        }
    }
}