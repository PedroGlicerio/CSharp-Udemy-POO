using System;
using Exe001.Entities;
class Program {
    public static void Main() {

        Console.Write("Digite o primeiro valor: ");
        int valor1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo valor: ");
        int valor2 = int.Parse(Console.ReadLine());

        Calculo soma = new Calculo(valor1, valor2);

        Console.WriteLine();
        Console.WriteLine(soma);
    }
}