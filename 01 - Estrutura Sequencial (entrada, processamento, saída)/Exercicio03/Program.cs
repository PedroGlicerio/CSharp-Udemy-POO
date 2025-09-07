using System;
using Exercicio03.Entities;
class Program {
    public static void Main() {

        Console.WriteLine("Digite 4 valores:");
        Console.WriteLine();
        Console.Write("Primeiro valor: ");
        int valor1 = int.Parse(Console.ReadLine());
        Console.Write("Segundo valor: ");
        int valor2 = int.Parse(Console.ReadLine());
        Console.Write("Terceiro valor: ");
        int valor3 = int.Parse(Console.ReadLine());
        Console.Write("Quarto valor: ");
        int valor4 = int.Parse(Console.ReadLine());

        Diferenca d = new Diferenca(valor1, valor2, valor3, valor4);

        Console.WriteLine();
        Console.WriteLine(d);
    }
}