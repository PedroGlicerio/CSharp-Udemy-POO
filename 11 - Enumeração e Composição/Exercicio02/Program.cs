using System;
using System.Globalization;
using Exercicio02.Entities;
class Program {
    public static void Main() {

        Console.Write("Quantas postagens deseja salvar: ");
        int numeroPostagem = int.Parse(Console.ReadLine());

        List<Postagem> postagens = new List<Postagem>();

        for (int i = 1; i <= numeroPostagem; i++) {

            Console.WriteLine();
            Console.WriteLine($"#{i}° Postagem:");
            Console.Write("Digite o título da postagem: ");
            string tituloPostagem = Console.ReadLine();
            Console.Write("Qual data/hora da postagem [DD/MM/AAAA] [HH:MM:SS] => ");
            string[] dataHora = Console.ReadLine().Split(" ");
            DateTime dataPostagem = DateTime.Parse($"{dataHora[0]} {dataHora[1]}");
            Console.Write("Conteúdo da postagem: ");
            string conteudoPostagem = Console.ReadLine();
            Console.Write("Quantos likes: ");
            int likesPostagem = int.Parse(Console.ReadLine());

            Postagem post = new Postagem(dataPostagem, tituloPostagem, conteudoPostagem, likesPostagem);

            Console.WriteLine();
            Console.Write("Quantos comentários teve na postagem: ");
            int numeroComentarios = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int j = 1; j <= numeroComentarios; j++) {

                Console.Write($"Digite o #{j}° comentário: ");
                string comentarioPostagem = Console.ReadLine();

                Comentarios comentario = new Comentarios(comentarioPostagem);
                post.AdicionarComentarioPostagem(comentario);
            }

            postagens.Add(post);
        }

        foreach (Postagem post in postagens) {

            Console.WriteLine();
            Console.WriteLine($"{post.Titulo}");
            Console.WriteLine($"{post.Likes} likes - {post.MomentoPostagem}");
            Console.WriteLine($"{post.Conteudo}");
            Console.WriteLine("Comentários:");
            Console.WriteLine($"{post.ComentariosPostagem()}");
        }
    }
}