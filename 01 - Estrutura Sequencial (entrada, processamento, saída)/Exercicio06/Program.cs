using System;
using System.Globalization;
using Exercicio06.Entities;

class Program {
    public static void Main() {

        Console.Write("Digite três valores para fazermos o cálculo da área: ");
        string[] valores = Console.ReadLine().Split(" ");
        double a = double.Parse(valores[0], CultureInfo.InvariantCulture);
        double b = double.Parse(valores[1], CultureInfo.InvariantCulture);
        double c = double.Parse(valores[2], CultureInfo.InvariantCulture);

        Figura f = new Figura(a, b, c);

        Console.WriteLine();
        Console.WriteLine(f);
    }
}
