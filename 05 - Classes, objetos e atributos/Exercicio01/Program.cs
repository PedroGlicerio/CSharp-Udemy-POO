using System;
using Exercicio01.Entities;
class Program {
    public static void Main() {

        Console.Write("Digite o número de pessoas que deseja: ");
        int N = int.Parse(Console.ReadLine());

        Pessoa n = new Pessoa(N);

        Console.WriteLine();
        n.pessoaMaisVelha();
    }
}