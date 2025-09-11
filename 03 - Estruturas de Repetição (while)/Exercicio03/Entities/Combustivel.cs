using System;

namespace Exercicio03.Entities {
    internal class Combustivel {

        public int Alcool { get; private set; }
        public int Gasolina { get; private set; }
        public int Diesel { get; private set; }

        public void Menu() {

            Console.WriteLine("======= COMBUSTIVEIS =======");
            Console.WriteLine("      Código     Produto");
            Console.WriteLine("============================");
            Console.WriteLine("        1        Alcool ");
            Console.WriteLine("        2       Gasolina");
            Console.WriteLine("        3        Diesel");
            Console.WriteLine("        4         Fim");
            Console.WriteLine("============================");
            Console.WriteLine();
        }

        public void tipoCombustivel() {

            Console.Write("Digite o código do combustível que deseja: ");
            int codigo = int.Parse(Console.ReadLine());

            while (codigo !=  4) {
                switch (codigo) {
                    case 1:
                        Alcool++;
                        break;
                    case 2:
                        Gasolina++;
                        break;
                    case 3:
                        Diesel++;
                        break;
                    default:
                        Console.WriteLine("Código inválido! Digite novamente!");
                        break;
                }

                Console.Write("Digite o código do combustível que deseja: ");
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine($"Alcool: {Alcool}\nGasolina: {Gasolina}\nDiesel: {Diesel}");
        }
    }
}
