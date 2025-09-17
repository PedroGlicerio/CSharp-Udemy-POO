using System;

namespace Exercicio02.Entities {
    internal class CalculoMedia {

        public static double valorMedia(Funcionarios f1, Funcionarios f2) {

            return (f1.Salario + f2.Salario) / 2;
        }
    }
}
