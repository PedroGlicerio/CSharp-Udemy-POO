using System;
using Exercicio01.Entities;
class Program {
    public static void Main() {

        Console.WriteLine("Dados da primeira pessoa");
        Console.WriteLine();
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        Pessoa p1 = new Pessoa(nome, idade);
        Console.WriteLine();

        Console.WriteLine("Dados da segunda pessoa");
        Console.WriteLine();
        Console.Write("Nome: ");
        nome = Console.ReadLine();
        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Pessoa p2 = new Pessoa(nome, idade);

        Console.WriteLine();
        Console.WriteLine($"{PessoaMaisVelha.pessoaVelha(p1, p2)}");
    }
}