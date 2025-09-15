using System;
using Exercicio07.Entities;
class Program {
    public static void Main() {

        Console.Write("Digite um valor: ");
        int N = int.Parse(Console.ReadLine());

        Conta conta = new Conta(N);

        conta.numConta();
    }
}

