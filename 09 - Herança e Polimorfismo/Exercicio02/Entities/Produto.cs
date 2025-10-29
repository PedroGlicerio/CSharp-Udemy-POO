using System;
using System.Globalization;

namespace Exercicio02.Entities {
    internal class Produto {

        public string Nome { get; set; }
        public double Preco { get; protected set; }

        public Produto(string nome, double preco) {

            Nome = nome;
            Preco = preco;
        }

        public virtual string TagPreco() {

            return $"{Nome} - R${Preco.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
