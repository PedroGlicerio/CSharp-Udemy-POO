using System;
using Exercicio03.Entities;

class Program {
    public static void Main() {

        Verificacao v = new Verificacao();

        Console.Write("Digite dois valores inteiros: ");
        string[] valores = Console.ReadLine().Split(" ");
        v.A = int.Parse(valores[0]);
        v.B = int.Parse(valores[1]);

        Console.WriteLine();
        Console.WriteLine(v.numerosMultiplos());

    }
}