using System;
using Exercicio05.Entities;
class Program {
    public static void Main() {

        Console.WriteLine("Código         Lanches          Preco");
        Console.WriteLine("=======================================");
        Console.WriteLine("  1        Cachorro Quente     R$ 4,00");
        Console.WriteLine("  2           X-Salada         R$ 4,50");
        Console.WriteLine("  3           X-Bacon          R$ 5,00");
        Console.WriteLine("  4        Torrada Simples     R$ 2,00");
        Console.WriteLine("  5         Refrigerante       R$ 1,00 ");
        Console.WriteLine("=======================================");
        Console.WriteLine();

        Lanches l = new Lanches();

        Console.Write("Digite o código do produto que deseja e a quantidade: ");
        string[] valores = Console.ReadLine().Split(" ");
        l.Codigo = int.Parse(valores[0]);
        l.Quantidade = int.Parse(valores[1]);

        Console.WriteLine();
        Console.WriteLine(l);
    }
}