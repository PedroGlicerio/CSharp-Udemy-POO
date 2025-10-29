using System;
using Exercicio01.Entities.Enums;
using System.Globalization;
using Exercicio01.Entities;
class Program {
    public static void Main() {

        Console.Write("Quantas figuras você deseja visualizar: ");
        int N = int.Parse(Console.ReadLine());

        List<Figura> list = new List<Figura>();

        for (int i = 0; i < N; i++) {

            Console.WriteLine();
            Console.WriteLine($"Figura #{i + 1}:");
            Console.Write("Retângulo ou Circulo [R/C]: ");
            char opc = char.Parse(Console.ReadLine().ToUpper());
            Console.Write("Cor [Preta/Azul/Vermelha]: ");
            Cor cor = Enum.Parse<Cor>(Console.ReadLine());

            if (opc == 'R') {

                Console.Write("Largura: ");
                double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Altura: ");
                double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Retangulo(largura, altura, cor));

            } else {

                Console.Write("Raio: ");
                double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Circulo(raio, cor));
            }
        }

        Console.WriteLine();
        Console.WriteLine("Área das figuras:");
        foreach (Figura obj in list) {
            Console.WriteLine(obj.Area().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}