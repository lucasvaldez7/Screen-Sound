using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenSound
{
    class Musica
    {

        public Musica(Banda artista, string nomeMusica)
        {
            Artista = artista;
            Nome = nomeMusica;

        }
        public string Nome { get; set; }
        public Banda Artista { get; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set;}
        public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}";
        public Genero Genero { get; set; }




        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista.Nome}");
            Console.WriteLine($"Duração: {Duracao}");

            if (Disponivel)
            {
                Console.WriteLine("Disponível no plano.");
            }
            else
            {
                Console.WriteLine("Adquira o plano Plus+");
            }

        }
    }
}
