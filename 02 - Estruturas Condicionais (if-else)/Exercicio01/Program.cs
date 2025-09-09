using System;
using Exercicio01.Entities;
class Program {
    public static void Main() {

        Console.Write("Digite um valor: ");
        int n = int.Parse(Console.ReadLine());

        Comparacao c = new Comparacao(n);

        Console.WriteLine();
        Console.WriteLine(c);
    }
}