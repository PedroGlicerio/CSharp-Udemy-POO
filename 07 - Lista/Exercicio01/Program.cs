using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio01.Entities;
class Program {
    public static void Main() {

        Console.Write("Quantos funcionários serão registrados: ");
        int N = int.Parse(Console.ReadLine());

        List<Funcionario> list = new List<Funcionario>();

        for (int i = 0; i < N; i++) {

            Console.WriteLine();
            Console.WriteLine($"Funcionário #{i + 1}:");
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Salário: R$");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            list.Add(new Funcionario(id, nome, salario));
        }

        Console.WriteLine();
        Console.Write("Digite o ID do funcionário que terá seu salário aumentado: ");
        int idFuncionario = int.Parse(Console.ReadLine());

        Funcionario f = list.Find(x => x.Id == idFuncionario);


        if (f != null) {
            Console.Write("Digite a porcentagem que será aumentada no salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentoSalarial(porcentagem);
        } else {
            Console.WriteLine("O ID digitado não pertence a nenhum funcionário informado acima!");
        }


        Console.WriteLine();
        Console.WriteLine("Lista atualizada dos funcionários:");
        foreach (Funcionario x in list) {
            Console.WriteLine(x);
        }
    }
}