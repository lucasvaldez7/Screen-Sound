namespace ScreenSound
{
    class Album
    {
        private List<Musica> musicas = new List<Musica>();

        public Album(string nomeAlbum)
        {
            Nome = nomeAlbum;

        }
        public string Nome { get; }

        public int DuracaoTotal => musicas.Sum(m => m.Duracao); //Pega todas as músicas da lista e soma a duração delas.
        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }
        public void ExibirMusicasDoAlbum()
        {
            Console.WriteLine($"Lista de músicas do álbum: {Nome}\n");
            foreach (var musica in musicas)
            {
                Console.WriteLine($"Música: {musica.Nome} ");

            }
            Console.WriteLine($"\nPara ouvir este álbum inteiro você precisa de {DuracaoTotal}");

        }
    }
}
