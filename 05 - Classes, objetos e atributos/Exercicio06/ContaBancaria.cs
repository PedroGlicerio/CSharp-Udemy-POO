using System;
using System.Globalization;
using System.Runtime;

namespace Exercicio06 {
    internal class ContaBancaria {

        public int Conta { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int conta, string titular) {

            Conta = conta;
            Titular = titular;
        }

        public ContaBancaria(int conta, string titular, double saldo) :this (conta, titular) {

            Saldo = saldo;
        }

        public void Deposito(double deposito) {

            Saldo += deposito;
        }

        public void Saque(double saque) {

            Saldo -= saque + 5;
        }

        public override string ToString() {
            return $"Conta {Conta}, Titular: {Titular}, Saldo: R${Saldo.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
