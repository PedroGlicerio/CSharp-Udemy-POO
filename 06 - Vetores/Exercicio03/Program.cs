using System;
using Teste.Entities;
class Program {

    public static void Main(string[] args) {

        Console.Write("Quantos quartos você gostaria de alugar: ");
        int N = int.Parse(Console.ReadLine());

        Estudante[] estudantes = new Estudante[10];

        for (int i = 0; i < N; i++) {

            Console.WriteLine();
            Console.WriteLine($"Aluguel #{i + 1}:");
            Console.WriteLine("============");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Quarto: ");
            int quarto = int.Parse(Console.ReadLine());

            estudantes[quarto] = new Estudante(nome, email, quarto);
        }

        Console.WriteLine();
        Console.WriteLine("Quartos ocupados:");
        for (int i = 0; i < estudantes.Length; i++) {
            if (estudantes[i] != null) {
                Console.WriteLine($"{estudantes[i].Quarto}: {estudantes[i].Nome}, {estudantes[i].Email}");
            }
        }
    }
}