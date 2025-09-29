using System;
using System.Globalization;

namespace Exercicio04.Entities {
    internal class Aluno {

        public string Nome { get; set; }
        public List<double> Notas { get; set; } = new List<double>();

        public Aluno() { }
        public Aluno(string nome) {

            Nome = nome;
        }

        public void AdicionarNotas(double notas) {

            Notas.Add(notas);
        }

        public string VerificarNotas() {

            double soma = 0;
            foreach (double nota in Notas) {
                soma += nota;
            }

            if (soma >= 60) {
                return $"NOTA FINAL = {soma.ToString("f2", CultureInfo.InvariantCulture)}\nAPROVADO";
            } else {
                double faltam = 60 - soma;
                return $"NOTA FINAL = {soma.ToString("f2", CultureInfo.InvariantCulture)}\nREPROVADO\nFALTARAM {faltam.ToString("f2", CultureInfo.InvariantCulture)} PONTOS";
            }
        }
    }
}
