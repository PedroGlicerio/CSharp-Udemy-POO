using System;
using System.Globalization;
using Exercicio06;
class Program {
    public static void Main() {

        ContaBancaria c;

        Console.Write("Entre o número da conta: ");
        int conta = int.Parse(Console.ReadLine());
        Console.Write("Entre o titular da conta: ");
        string titular = Console.ReadLine();
        Console.Write("Haverá depósito inicial [S/N]: ");
        char resp = char.Parse(Console.ReadLine().ToUpper());

        if (resp == 'N') {

            c = new ContaBancaria(conta, titular);

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c);
        } else {

            Console.Write("Entre o valor do depósito inicial: R$");
            double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            c = new ContaBancaria(conta, titular, saldo);

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c);
        }

        Console.WriteLine();
        Console.Write("Entre um valor para o depósito: R$");
        double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        c.Deposito(deposito);
        Console.WriteLine();
        Console.WriteLine("Dados da conta atualizados:");
        Console.WriteLine(c);

        Console.WriteLine();

        Console.Write("Entre um valor para saque: R$");
        double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        c.Saque(saque);
        Console.WriteLine();
        Console.WriteLine("Dados da conta atualizados:");
        Console.WriteLine(c);
    }
}