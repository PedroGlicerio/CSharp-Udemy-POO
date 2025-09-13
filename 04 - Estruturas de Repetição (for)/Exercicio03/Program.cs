using System;
using Exercicio03.Entities;
class Program {
    public static void Main() {

        Console.Write("Digite um valor: ");
        int N = int.Parse(Console.ReadLine());

        Media media = new Media(N);

        Console.WriteLine();
        media.numeroMedia();
        Console.WriteLine();
    }
}