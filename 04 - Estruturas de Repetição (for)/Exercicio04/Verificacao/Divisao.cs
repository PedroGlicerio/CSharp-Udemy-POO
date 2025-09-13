using System;


namespace Exercicio04.Verificacao {
    internal class Divisao {

        public int Numero { get; set; }


        public Divisao(int numero) {

            Numero = numero;
        }

        public void numDiv() {

            for (int i = 0; i < Numero; i++) {

                Console.Write("Digite dois valores para receber o resultado da divisao: ");
                string[] valores = Console.ReadLine().Split(" ");
                double valor1 = double.Parse(valores[0]);
                double valor2 = double.Parse(valores[1]);

                if (valor2 == 0) {
                    Console.WriteLine("Divisão impossível!");
                } else {
                    Console.WriteLine($"{valor1 / valor2}");
                }

                Console.WriteLine();
            }
        }
    }
}
