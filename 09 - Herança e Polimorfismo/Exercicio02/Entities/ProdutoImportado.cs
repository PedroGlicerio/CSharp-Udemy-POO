using System;
using System.Globalization;

namespace Exercicio02.Entities {
    internal class ProdutoImportado : Produto {

        public double TaxaImportacao { get; set; }

        public ProdutoImportado(string nome, double preco, double taxaImportacao) :base (nome, preco) {

            TaxaImportacao = taxaImportacao;
        }

        public double PrecoTotal() {

            return Preco += TaxaImportacao;
        }

        public override string TagPreco() {

            return $"{Nome} - R${PrecoTotal().ToString("F2", CultureInfo.InvariantCulture)} (Taxa: R${TaxaImportacao.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
