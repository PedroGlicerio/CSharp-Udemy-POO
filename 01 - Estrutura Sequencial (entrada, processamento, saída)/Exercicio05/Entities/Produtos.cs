using System;


namespace Exercicio05.Entities {
    internal class Produtos {

        public int Codigo { get; set; }
        public int Quantidade { get; set; }
        public double Valor { get; set; }

        public Produtos() {
        }

        public Produtos(int codigo, int quantidade, double valor) {

            Codigo = codigo;
            Quantidade = quantidade;
            Valor = valor;
        }

        public double valorPagar() {

            return Valor * Quantidade;
        }
    }
}
