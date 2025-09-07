using System;
using System.Globalization;
using Exercicio02.Entities;
class Program {
    public static void Main() {

        Console.Write("Digite o valor do raio: ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Circulo r = new Circulo(raio);

        Console.WriteLine();
        Console.WriteLine(r);
    }
}