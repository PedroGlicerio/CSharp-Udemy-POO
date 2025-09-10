using System;
using System.Globalization;
using Exercicio06.Entities;
class Program {
    public static void Main() {

        Console.Write("Digite um valor para saber em qual intervalo ele pertence: ");
        double n = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Intervalo intervalo = new Intervalo(n);

        Console.WriteLine();
        Console.WriteLine(intervalo);
    }
}