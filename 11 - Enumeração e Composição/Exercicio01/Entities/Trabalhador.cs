using Exercicio01.Entities.Enums;

namespace Exercicio01.Entities {
    internal class Trabalhador {

        public string Nome { get; set; }
        public NivelTrabalhador Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; } // um-para-um
        public List<ContratoHoras> Contratos { get; set; } = new List<ContratoHoras>(); // um-para-muitos (lista)

        public Trabalhador(string nome, NivelTrabalhador nivel, double salarioBase, Departamento departamento) {

            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public void AdicionarContrato(ContratoHoras contrato) {

            Contratos.Add(contrato);
        }

        public void RemoverContrato(ContratoHoras contrato) {

            Contratos.Remove(contrato);
        }

        public double RendaMesEAno(int mes, int ano) {

            double soma = SalarioBase;
            foreach (ContratoHoras contrato in Contratos) {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes) {

                    soma += contrato.ValorTotal();
                }
            }

            return soma;
        }
    }
}
