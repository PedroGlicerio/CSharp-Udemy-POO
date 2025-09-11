using System;
using Exercicio01.Entities;
class Program {
    public static void Main() {

        Console.Write("Digite sua senha: ");
        int senha = int.Parse(Console.ReadLine());

        Verificacao verificacao = new Verificacao(senha);

        verificacao.senhaCorreta();
    }
}