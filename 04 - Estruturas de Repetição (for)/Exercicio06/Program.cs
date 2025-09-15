using System;
using Exercicio06.Entities;

class Program {
    public static void Main() {

        Console.Write("Digite um valor para ver seus divisores: ");
        int N = int.Parse(Console.ReadLine());

        Divisor divisor = new Divisor(N);

        Console.WriteLine();
        divisor.numDiv();
    }
}