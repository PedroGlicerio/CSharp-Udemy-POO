using System;
using System.Globalization;
using System.Numerics;
using Exercicio02.Entities;
class Program {
    public static void Main() {

        Console.Write("Entre o número de contribuintes: ");
        int N = int.Parse(Console.ReadLine());

        List<Contribuinte> list = new List<Contribuinte>();

        for (int i = 0; i < N; i++) {

            Console.WriteLine();
            Console.WriteLine($"Contribuinte #{i + 1}:");
            Console.Write("Pessoa física ou Pessoa jurídica [F/J]: ");
            char opc = char.Parse(Console.ReadLine().ToUpper());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Salário anual: R$");
            double salarioAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (opc == 'F') {

                Console.Write("Gasto com saúde: R$");
                double gastoSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new PessoaFisica(nome, salarioAnual, gastoSaude));

            } else {

                Console.Write("Número de funcionários: ");
                int numeroFuncionarios = int.Parse(Console.ReadLine());

                list.Add(new PessoaJuridica(nome, salarioAnual, numeroFuncionarios));

            }
        }

        Console.WriteLine();
        double soma = 0;
        Console.WriteLine("Taxas pagas:");
        foreach (Contribuinte pessoa in list) {
            Console.WriteLine($"{pessoa.Nome}: R${pessoa.Taxa().ToString("F2", CultureInfo.InvariantCulture)}");
            soma += pessoa.Taxa();
        }

        Console.WriteLine();
        Console.WriteLine($"Total de taxas: R${soma.ToString("F2", CultureInfo.InvariantCulture)}");
    }
}