using System;
using System.Net.WebSockets;
class Program {
    public static void Main() {

        Console.Write("Digite o tamanho da matriz que deseja criar: ");
        int tamanhoMatriz = int.Parse(Console.ReadLine());

        int[,] mat = new int[tamanhoMatriz, tamanhoMatriz];

        Console.WriteLine();

        for (int i = 0; i < tamanhoMatriz; i++) { // percorre a linha da matriz

            string[] valores = Console.ReadLine().Split(" ");

            for (int j = 0; j < tamanhoMatriz; j++) { // percorre a coluna da matriz

                mat[i, j] = int.Parse(valores[j]);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Diagonal principal:");
        for (int i = 0; i < tamanhoMatriz; i++) {
            Console.Write($"{mat[i, i]} ");
        }

        Console.WriteLine();
        double numerosNegativos = 0;
        for (int i = 0; i < tamanhoMatriz; i++) {
            for (int j = 0; j < tamanhoMatriz; j++) {
                if (mat[i, j] < 0) {
                    numerosNegativos++;
                }
            }
        }

        Console.Write($"Números negativos presente(s) na matriz: {numerosNegativos}");
        Console.WriteLine();
    }
}                                                                                                                                                                                                                                   