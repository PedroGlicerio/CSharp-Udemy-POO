using System;
using Exercicio02.Entities;
class Program {
    public static void Main() {

        Console.Write("Digite o total de número que serão arquivados: ");
        int N = int.Parse(Console.ReadLine());

        Intervalo intervalo = new Intervalo(N);

        Console.WriteLine();
        intervalo.dentroIntervalo();
    }
}
