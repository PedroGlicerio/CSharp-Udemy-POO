using System;
using System.Globalization;
using Exercicio01.Entities;
using Exercicio01.Entities.Enums;

class Program {
    public static void Main() {

        Console.Write("Entre com o nome do departamento: ");
        string departamento = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("Entre com os dados do trabalhador:");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Level [Junior/Senior/Pleno]: ");
        NivelTrabalhador nivel = Enum.Parse<NivelTrabalhador>(Console.ReadLine());
        Console.Write("Base salarial: R$");
        double baseSalarial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Departamento departamentoTrabalhador = new Departamento(departamento);
        Trabalhador trabalhador = new Trabalhador(nome, nivel, baseSalarial, departamentoTrabalhador);

        Console.WriteLine();

        Console.Write("Quantos contratos o trabalhador terá: ");
        int numeroContrato = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numeroContrato; i++) {

            Console.WriteLine();
            Console.WriteLine($"Entre com os dados do #{i}° contrato:");
            Console.Write("Data [DD/MM/AAAA]: ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.Write($"Valor por hora: R$");
            double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Duração [Horas]: ");
            int horas = int.Parse(Console.ReadLine());

            ContratoHoras contrato = new ContratoHoras(data, valorPorHora, horas);
            trabalhador.AdicionarContrato(contrato);
        }

        Console.WriteLine();

        Console.Write("Entre com o mês e o ano que deseja calcular [MM/AAAA]: ");
        string mesEAno = Console.ReadLine();

        int mes = int.Parse(mesEAno.Substring(0, 2));
        int ano = int.Parse(mesEAno.Substring(3));

        Console.WriteLine();

        Console.WriteLine($"Nome: {trabalhador.Nome}");
        Console.WriteLine($"Departamento: {trabalhador.Departamento.Nome}");
        Console.WriteLine($"Renda referente a data [{mesEAno}]: R${trabalhador.RendaMesEAno(mes, ano).ToString("F2", CultureInfo.InvariantCulture)}");
        
    }
}