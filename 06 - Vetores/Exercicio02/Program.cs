using System;
using System.Globalization;
using Teste.Entities;
class Program {

    public static void Main(string[] args) {

        Console.Write("Digite quantos produtos você deseja passar: ");
        int N = int.Parse(Console.ReadLine());

        Produtos[] produtos = new Produtos[N];

        for (int i = 0; i < N; i++) {

            Console.WriteLine();
            Console.Write($"Digite o nome do {i + 1}° produto: ");
            string nome = Console.ReadLine();
            Console.Write($"Digite o preço do {i + 1}° produto: R$");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            produtos[i] = new Produtos(nome, preco);
        }

        double soma = 0;
        foreach (Produtos p in produtos) {
            soma += p.Preco;
        }

        double media = soma / N;

        Console.WriteLine();
        Console.Write($"A média dos preços de {N} produtos foi: R${media.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}