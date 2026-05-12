using ScreenSound;

Musica musica1 = new Musica();

musica1.nome = "Roxane";
musica1.artista = "The Police";
musica1.duracao = 1;
musica1.EscreveDisponivel(true);
Console.WriteLine(musica1.LeDisponivel());

musica1.ExibirFichaTecnica();   