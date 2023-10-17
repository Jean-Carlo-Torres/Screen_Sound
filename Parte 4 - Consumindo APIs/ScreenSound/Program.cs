using System.Text.Json;
using ScreenSound.Filters;
using ScreenSound.Models;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        // Console.WriteLine(resposta);
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Lana Del Rey");
        LinqFilter.FiltrarMusicasPorTonalidade(musicas, "C#");

        var minhasMusicasFavoritas = new MusicasPreferidas("Jean");
        minhasMusicasFavoritas.AdicionarMusicaFavoritas(musicas[1]);
        minhasMusicasFavoritas.AdicionarMusicaFavoritas(musicas[2]);
        minhasMusicasFavoritas.AdicionarMusicaFavoritas(musicas[3]);
        minhasMusicasFavoritas.AdicionarMusicaFavoritas(musicas[4]);
        minhasMusicasFavoritas.AdicionarMusicaFavoritas(musicas[5]);

        minhasMusicasFavoritas.ExibirMusicasFavoritas();

        minhasMusicasFavoritas.GerarArquivoJson();

        Console.WriteLine();
        musicas[2].ExibirDetalhesDaMusica();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}