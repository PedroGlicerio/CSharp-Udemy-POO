namespace Exercicio02.Entities {
    internal class Postagem {

        public DateTime MomentoPostagem { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int Likes { get; set; }
        public List<Comentarios> Comentarios { get; set; } = new List<Comentarios>();

        public Postagem(DateTime momentoPostagem, string titulo, string conteudo, int likes) {

            MomentoPostagem = momentoPostagem;
            Titulo = titulo;
            Conteudo = conteudo;
            Likes = likes;
        }

        public void AdicionarComentarioPostagem(Comentarios comentario) {

            Comentarios.Add(comentario);
        }

        public void RemoverComentarioPostagem(Comentarios comentario) {

            Comentarios.Remove(comentario);
        }

        public string ComentariosPostagem() {

            string resultado = "";

            foreach (Comentarios obj in Comentarios) {

                resultado += $"{obj.Texto}\n";
            }

            return resultado;
        }
    }
}
