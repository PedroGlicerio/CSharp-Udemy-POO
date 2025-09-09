using System;
using Exercicio02.Entities;
class Program {

    public static void Main() {

        Console.Write("Digite um número para verificar se ele é PAR ou IMPAR: ");
        int n = int.Parse(Console.ReadLine());

        Comparacao c = new Comparacao(n);

        Console.WriteLine();
        Console.WriteLine(c);
    }
}