using System;
using Exercicio05.Entities;
class Program {
    public static void Main() {

        Console.Write("Digite um valor para ver seu fatorial: ");
        int fat = int.Parse(Console.ReadLine());

        Fatorial fatorial = new Fatorial(fat);

        Console.WriteLine();
        fatorial.contaFat();

    }
}
