using ScreenSound;

Banda radioHead = new Banda("RadioHead");


Album albumRadioHead = new Album("OK Computer");

Musica musica1 = new Musica(radioHead,"Let Down");
musica1.Duracao = 120;

Musica musica2 = new Musica(radioHead,"Karma Police");
musica2.Duracao = 150;
musica2.Disponivel = true;

albumRadioHead.AdicionarMusica(musica1);
albumRadioHead.AdicionarMusica(musica2);



radioHead.AdicionarAlbum(albumRadioHead);
radioHead.ExibirDiscografia();

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();