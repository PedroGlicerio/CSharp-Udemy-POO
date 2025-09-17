using System;
using System.Globalization;
using Exercicio02.Entities;
class Program {
    public static void Main() {

        Console.WriteLine("Digite os dados de dois funcionários");
        Console.WriteLine();
        Console.WriteLine("Funcionário 1:");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Salário: ");
        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        Funcionarios f1 = new Funcionarios(nome, salario);

        Console.WriteLine();
        Console.WriteLine("Funcionário 2:");
        Console.Write("Nome: ");
        nome = Console.ReadLine();
        Console.Write("Salário: ");
        salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Funcionarios f2 = new Funcionarios(nome, salario);

        Console.WriteLine();
        Console.WriteLine($"Salário médio = {CalculoMedia.valorMedia(f1, f2):f2}");

    }
}
