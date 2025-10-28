using System;
using System.Globalization;
using Exercicio01.Entities;
class Program {
    public static void Main() {

        Console.Write("Entre o número de empregados que deseja registrar: ");
        int N = int.Parse(Console.ReadLine());

        List<Funcionario> list = new List<Funcionario>();

        for (int i = 0; i < N; i++) {

            Console.WriteLine();
            Console.WriteLine($"Funcionário #{i + 1} dados:");
            Console.Write("Funcionário terceirizado [S/N]: ");
            char opc = char.Parse(Console.ReadLine().ToUpper());

            if (opc == 'N') {

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Funcionario(nome, horas, valorHora));

            } else {

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Despesa adicional: ");
                double despesa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Terceirizados(nome, horas, valorHora, despesa));
            }
        }

        Console.WriteLine();
        Console.WriteLine("Pagamentos:");
        foreach(Funcionario obj in list) {
            Console.WriteLine(obj);
        }
    }
}