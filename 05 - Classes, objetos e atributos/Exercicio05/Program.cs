using System;
using System.Globalization;
using Exercicio05.Entities;
class Program {
    public static void Main() {

        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Salário Bruto: R$");
        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Imposto: R$");
        double imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Funcionario f = new Funcionario(nome, salario, imposto);

        Console.WriteLine();
        Console.WriteLine($"Funcionário: {f}");
        Console.WriteLine();

        Console.Write("Digite a porcentagem para aumentar o salário: ");
        double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        f.AumentarSalario(porcentagem);

        Console.WriteLine();
        Console.WriteLine($"Dados atualizados: {f}");
    }
}