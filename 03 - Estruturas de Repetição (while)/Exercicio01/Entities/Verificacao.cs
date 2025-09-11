using System;
using System.ComponentModel.Design;
using System.Reflection.Metadata.Ecma335;

namespace Exercicio01.Entities {
    internal class Verificacao {

        public int Senha { get; set; }

        public Verificacao(int senha) {

            Senha = senha;
        }

        public void senhaCorreta() {

            while (Senha != 2002) {

                Console.WriteLine();
                Console.WriteLine("Senha inválida!");
                Console.Write("Digite sua senha novamente: ");
                Senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Acesso Permitido! Bem-vindo!");
        }
    }
}
