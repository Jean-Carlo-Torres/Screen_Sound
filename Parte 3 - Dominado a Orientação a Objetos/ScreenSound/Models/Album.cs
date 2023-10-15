using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenSound.Models;

internal class Album : IAvaliacao
{

    private List<Musica> musicas = new List<Musica>();
    private List<Avaliacao> notas = new List<Avaliacao>();
    public Album(string nome)
    {
        Nome = nome;
    }
    
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public List<Musica> Musicas => musicas;

    public double Media {
        get {
            if(notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
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