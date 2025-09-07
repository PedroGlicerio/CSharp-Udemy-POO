using System;

namespace Exercicio04.Entities {
    internal class Salario {

        public int Numero { get; set; }
        public int Horas { get; set; }
        public double Valor { get; set; }

        public Salario(int numero, int horas, double valor) {

            Numero = numero;
            Horas = horas;
            Valor = valor;
        }

        public double valorSalario() {

            return Horas * Valor;
        }

        public override string ToString() {
            return $"Número: {Numero}\nSalário: R${valorSalario():f2}";
        }
    }
}
