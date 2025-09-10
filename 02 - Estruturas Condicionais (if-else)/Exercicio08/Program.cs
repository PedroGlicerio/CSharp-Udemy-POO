using System;
using System.Globalization;
using Exercicio08.Entities;
class Program {
    public static void Main() {

        Console.Write("Digite o valor do seu salário: ");
        double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        ImpostoDeRenda imp = new ImpostoDeRenda(salario);
        imp.Renda(salario);

        Console.WriteLine();
        Console.WriteLine(imp);
    }
}