using System;
using System.Globalization;
using Exercicio02.Entities;
class Program {
    public static void Main() {

        Console.Write("Quantos produtos você deseja registrar: ");
        int N = int.Parse(Console.ReadLine());

        List<Produto> list = new List<Produto>();

        for (int i = 0; i < N; i++) {

            Console.WriteLine();
            Console.WriteLine($"Produto #{i + 1}:");
            Console.Write("Comum, Importado ou Usado [C/I/U]: ");
            char opc = char.Parse(Console.ReadLine().ToUpper());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preco: R$");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (opc == 'C') {

                list.Add(new Produto(nome, preco));

            } else if (opc == 'I') {

                Console.Write("Taxa: R$");
                double taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new ProdutoImportado(nome, preco, taxa));

            } else {

                Console.Write("Data de fabricação [DD/MM/YYYY]: ");
                DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());

                list.Add(new ProdutoUsado(nome, preco, dataFabricacao));
            }

        }

        Console.WriteLine();
        Console.WriteLine("Tabela de Preços:");
        foreach (Produto obj in list) {
            Console.WriteLine(obj.TagPreco());
        }
    }
}