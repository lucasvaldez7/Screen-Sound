using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenSound
{
      class Musica
    {
        public string nome;
        public string artista;
        public int duracao;
        public bool disponivel;

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Artista: {artista}");
            Console.WriteLine($"Duração: {duracao}");
            Console.WriteLine($"Disponível: {disponivel}");

        }
    }
}
