using System;
using System.Collections.Generic;
using System.Text;

namespace ScreenSound
{
    class Music
    {
        public string Artista { get; set; }
        public string Nome { get; set; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }

        public string DescriacaoResumida => $"A banda {Nome} Pertence ao {Artista}";


        public Music(string artista, string nome, int duracao ,bool disponivel)
        {
            this.Artista = artista;
            this.Nome = nome;
            this.Duracao = duracao;
            this.Disponivel = disponivel;
           
        }

        public void ExibirFichaTecnica()
        {
            
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Duração: {Duracao} segundos");
            Console.WriteLine($"Disponível: {(Disponivel ? "Sim" : "Não")}\n");
            Console.WriteLine($"Descrição Resumida: {DescriacaoResumida}\n");
           
        }
    }
}

