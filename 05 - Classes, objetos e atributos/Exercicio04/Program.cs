using System;
using System.Globalization;
using Exercicio04.Entities;
class Program {
    public static void Main() {

        Console.Write("Nome do Aluno: ");
        string nome = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Digite as três notas do aluno:");
        
        Aluno aluno = new Aluno(nome);

        for (int i = 0; i < 3; i++) {

            Console.Write($"Digite a {i + 1}° nota: ");
            double notas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            aluno.AdicionarNotas(notas);
        }

        Console.WriteLine();
        Console.WriteLine(aluno.VerificarNotas());
    }
}