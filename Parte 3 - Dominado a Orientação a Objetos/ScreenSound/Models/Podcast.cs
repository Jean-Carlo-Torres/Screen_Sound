using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenSound.Models
{
    public class Podcast
    {

        List<Episodio> episodios = new();
        public string Host { get; }
        public string Nome { get; }
        public int TotalEpisodios => episodios.Count;

        public Podcast(string nome, string host)
        {
            Host = host;
            Nome = nome;
        }

        public void AdicionarEpisodio(Episodio episodio)
        {
            episodios.Add(episodio);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"PodCast: {Nome} apresentado por {Host}\n");
            foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
            {
                Console.WriteLine(episodio.Resumo);
            }
            Console.WriteLine($"\nTotal de episódios: {TotalEpisodios}\n");
        
        }
    }
}


