using System;
using Exercicio04.Verificacao;
class Program {
    public static void Main() {

        Console.Write("Digite um valor para contagem: ");
        int N = int.Parse(Console.ReadLine());

        Divisao divisao = new Divisao(N);

        Console.WriteLine();
        divisao.numDiv();

    }
}