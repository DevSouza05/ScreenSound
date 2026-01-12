using ScreenSound;

Album albumDoQueen = new Album();
albumDoQueen.Name = "A night at the opera"; 

Music musica1 = new Music(
    "PetersonM",
    "PetM",
    330,
    true);

Music musica2 = new Music(
    "Juli",
    "Julia",
    330,
    false);

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

albumDoQueen.ExibirMusicasDoAlbum();

