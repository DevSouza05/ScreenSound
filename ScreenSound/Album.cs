using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenSound
{
    class Album
    {
        private List<Music> musics = new List<Music>();
        public string Name { get; set; }
        public int DuracaoTotal { get; set; }

        public void AdicionarMusica(Music musica)
        {
            musics.Add(musica);
        }

        public void ExibirMusicasDoAlbum()
        {
            Console.WriteLine($"musicas do almbum {Name}\n");

            foreach (var music in musics)
            {
                Console.WriteLine($"musica: {music.Nome}");
            }
        }
    }
}
