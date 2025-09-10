using System;
using System.Globalization;
using Exercicio07.Entities;
class Program {
    public static void Main() {

        Console.Write("Digite duas coordenadas [X, Y]: ");
        string[] valores = Console.ReadLine().Split(" ");
        Coordenadas coordenadas = new Coordenadas(double.Parse(valores[0], CultureInfo.InvariantCulture), double.Parse(valores[1], CultureInfo.InvariantCulture));

        Console.WriteLine();
        Console.WriteLine(coordenadas);
    }
}