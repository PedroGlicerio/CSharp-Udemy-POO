using System;
using Exercicio04.Entities;

class Program {
    public static void Main() {

        Horario h = new Horario();

        Console.Write("Digite a hora inicial e final do jogo: ");
        string[] valores = Console.ReadLine().Split(" ");
        h.A = int.Parse(valores[0]);
        h.B = int.Parse(valores[1]);

        Console.WriteLine();
        Console.WriteLine(h);
    }
}