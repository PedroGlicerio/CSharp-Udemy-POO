using System;
using System.Globalization;
using Exercicio05.Entities;
class Program {
    public static void Main() {

        Produtos p1 = new Produtos();

        Console.WriteLine("Peça 1");
        Console.Write("Digite o código, o números de peças e o valor unitário de cada peça: ");
        string[] s1 = Console.ReadLine().Split(" ");
        p1.Codigo = int.Parse(s1[0]);
        p1.Quantidade = int.Parse(s1[1]);
        p1.Valor = double.Parse(s1[2], CultureInfo.InvariantCulture);

        Produtos p2 = new Produtos();

        Console.WriteLine();
        Console.WriteLine("Peça 2");
        Console.Write("Digite o código, o números de peças e o valor unitário de cada peça: ");
        string[] s2 = Console.ReadLine().Split(" ");
        p2.Codigo = int.Parse(s2[0]);
        p2.Quantidade = int.Parse(s2[1]);
        p2.Valor = double.Parse(s2[2], CultureInfo.InvariantCulture);

        Console.WriteLine();
        double total = p1.valorPagar() + p2.valorPagar();
        Console.WriteLine($"Valor a pagar: R${total:f2}");
    }
}