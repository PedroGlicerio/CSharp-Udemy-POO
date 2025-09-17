using System;

namespace Exercicio02.Entities {
    internal class Funcionarios {

        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionarios(string nome, double salario) {

            Nome = nome;
            Salario = salario;
        }
    }
}
