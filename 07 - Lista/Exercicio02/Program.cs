using System;
using System.Globalization;
using Exercicio02.Entities;
class Program {
    public static void Main() {

        Console.Write("Quantos produtos serão cadastrados: ");
        int N = int.Parse(Console.ReadLine());

        List<Produto> list = new List<Produto>();

        for (int i = 0; i < N; i++) {

            Console.WriteLine();
            Console.WriteLine($"Produto #{i + 1}:");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: R$");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            list.Add(new Produto(id, nome, preco, quantidade));
        }

        Console.WriteLine();
        Console.Write("Entre com o ID do produto que deseja atualizar: ");
        int idProduto = int.Parse(Console.ReadLine());

        Produto p = list.Find(x => x.Id == idProduto);

        if (p != null) {

            Console.Write("Deseja adicionar ou remover unidades [A/R]: ");
            char opc = char.Parse(Console.ReadLine().ToUpper());

            switch (opc) {
                case 'A':
                    Console.Write("Quantas unidades deseja adicionar: ");
                    int quantidade = int.Parse(Console.ReadLine());
                    p.AdicionarUnidades(quantidade);
                    break;
                case 'R':
                    Console.Write("Quantas unidades deseja remover: ");
                    quantidade = int.Parse(Console.ReadLine());
                    p.RemoverUnidades(quantidade);
                    break;
            } 
        } else {
            Console.WriteLine("O ID informado não existe!");
        }

            Console.WriteLine();
        Console.WriteLine("Lista atualizada de produtos:");
        foreach (Produto obj in list) {
            Console.WriteLine(obj);
        }
    }
}