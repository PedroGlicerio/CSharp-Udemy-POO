using System;
using System.Globalization;
using Exercicio03.Entities;
using Exercicio03.Entities.Enums;
class Program {
    public static void Main() {

        Console.WriteLine("Entre com os dados do cliente:");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Data de aniversário [DD/MM/AAAA] => ");
        DateTime dataAniversario = DateTime.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("Entre com os dados do pedido:");
        Console.Write("Status: ");
        StatusPedido status = Enum.Parse<StatusPedido>(Console.ReadLine());

        Cliente cliente = new Cliente(nome, email, dataAniversario);
        Pedido pedido = new Pedido(DateTime.Now, status, cliente);

        Console.WriteLine();

        Console.Write("Quantos itens serão adicionados no pedido: ");
        int numeroItems = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numeroItems; i++) {

            Console.WriteLine();
            Console.WriteLine($"Entre com os dados do #{i}° produto:");
            Console.Write("Nome do produto: ");
            string nomeProduto = Console.ReadLine();
            Console.Write("Preço do produto: R$");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade do produto: ");
            int quantidadeProduto = int.Parse(Console.ReadLine());

            Produto produto = new Produto(nomeProduto, precoProduto);
            ItemPedido item = new ItemPedido(quantidadeProduto, precoProduto, produto);

            pedido.AdicionarItem(item);
        }

        Console.WriteLine();
        Console.WriteLine("Histórico das compras:");
        Console.WriteLine(pedido);

    }
}