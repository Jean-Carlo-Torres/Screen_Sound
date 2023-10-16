using System.Linq;
using ScreenSound.Models;

namespace ScreenSound.Filters;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var aristasPorGeneroMusical = musicas.Where(musica =>
        musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Artistas do gênero musical {genero.ToUpper()}:");
        foreach (var arista in aristasPorGeneroMusical)
        {
            Console.WriteLine($"- {arista}");

        }
    }
}