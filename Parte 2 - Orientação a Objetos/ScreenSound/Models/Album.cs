using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenSound.Models
{
    public class Album
    {

        private List<Musica> musicas = new List<Musica>();
        public Album(string nome)
        {
            Nome = nome;
        }
        
        public string Nome { get; }
        public int DuracaoTotal => musicas.Sum(m => m.Duracao);

        public void AdicionarMusica(Musica musica)
        {
            musicas.Add(musica);
        }

        public void ExibirMusicaDoAlbum()
        {
            Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
            foreach (Musica musica in musicas)
            {
                Console.WriteLine("- " + musica.Nome);
            }
            Console.WriteLine($"\nDuração total do álbum: {DuracaoTotal} segundos\n");
        }
    }
}