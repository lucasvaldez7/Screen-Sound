using ScreenSound;

Album albumRadioHead = new Album();

albumRadioHead.Nome = "OK Computer";

Musica musica1 = new Musica();
musica1.Nome = "Let Down";
musica1.Duracao = 120;

Musica musica2 = new Musica();
musica2.Nome = "Karma Police";
musica2.Duracao = 150;


albumRadioHead.AdicionarMusica(musica1);
albumRadioHead.AdicionarMusica(musica2);

albumRadioHead.ExibirMusicasDoAlbum();
