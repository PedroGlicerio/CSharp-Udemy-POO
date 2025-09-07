using System;
using System.Globalization;
using Exercicio04.Entities;
class Program {
    public static void Main() {

        Console.Write("Número do funcionário: ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Horas trabalhadas: ");
        int horas = int.Parse(Console.ReadLine());
        Console.Write("Valor por hora: ");
        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Salario s = new Salario(num, horas, valor);

        Console.WriteLine();
        Console.WriteLine(s);
    }
}