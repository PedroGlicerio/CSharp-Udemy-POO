using System;
using System.Globalization;
class Program {

    public static void Main(string[] args) {

        Console.Write("Digite um valor N para quantos números deseja salvar: ");
        int N = int.Parse(Console.ReadLine());

        double[] vect = new double[N];

        Console.WriteLine();

        for (int i = 0; i < N; i++) {

            Console.Write($"Digite o {i + 1}° valor: ");
            vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        double soma = 0;
        foreach (double numeros in vect) {
            soma += numeros;
        }

        double media = soma / N;

        Console.WriteLine();
        Console.WriteLine($"A média dos {N} números digitados foi: {media.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}