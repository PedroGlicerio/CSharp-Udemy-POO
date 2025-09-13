using System;
using System.Globalization;

namespace Exercicio03.Entities {
    internal class Media {

        public int Numero { get; set; }

        public Media(int numero) {

            Numero = numero;
        }

        public void numeroMedia() {

            for (int i = 0; i < Numero; i++) {

                Console.Write($"Digite os valores: ");
                string[] n = Console.ReadLine().Split(" ");
                double valor1 = double.Parse(n[0], CultureInfo.InvariantCulture);
                double valor2 = double.Parse(n[1], CultureInfo.InvariantCulture);
                double valor3 = double.Parse(n[2], CultureInfo.InvariantCulture);

                
                double media = (valor1 * 2 + valor2 * 3 + valor3 * 5) / 10;
                Console.WriteLine($"Resultado: {media:f1}");
                Console.WriteLine();
            }
        }
    }
}
