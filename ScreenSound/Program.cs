using ScreenSound;

Musica musica1 = new Musica();

musica1.Nome = "Roxane";
musica1.Artista = "The Police";
musica1.Duracao = 1;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);

musica1.ExibirFichaTecnica();   