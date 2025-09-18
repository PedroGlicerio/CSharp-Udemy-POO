using System;
using System.Globalization;
using Exercicio03.Entities;
class Program {
    public static void Main() {

        Console.WriteLine("Entre os dados do produto:");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Preço: ");
        double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantidade: ");
        int quantidade = int.Parse(Console.ReadLine());

        Produto p = new Produto(nome, preco, quantidade);

        Console.WriteLine();
        Console.WriteLine(p);
        Console.WriteLine();

        Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
        quantidade = int.Parse(Console.ReadLine());
        p.AdicionarProdutos(quantidade);
        Console.WriteLine();

        Console.WriteLine($"Dados atualizados: {p}");
        Console.WriteLine();

        Console.Write("Digite o número de produtos a ser removido do estoque: ");
        quantidade = int.Parse(Console.ReadLine());
        p.RemoverProdutos(quantidade);
        Console.WriteLine();

        Console.WriteLine($"Dados atualizados: {p}");
    }
}