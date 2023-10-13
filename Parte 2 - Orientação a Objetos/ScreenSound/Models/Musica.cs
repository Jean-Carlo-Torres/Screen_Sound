using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenSound.Models
{
    public class Musica
    {
        public string Nome { get; }
        public Banda Artista { get; }
        public string Genero { get; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }
        public string Descricao => $"Música {Nome} do artista {Artista}";

        public Musica(Banda artista, string nome, string genero)
        {
            Nome = nome;
            Artista = artista;
            Genero = genero;
        }

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Música: {Nome}");
            Console.WriteLine($"Artista: {Artista.Nome}");
            Console.WriteLine($"Gênero: {Genero}");
            Console.WriteLine($"Duração: {Duracao} segundos");
            if (Disponivel)
            {
                Console.WriteLine("Disponível no plano");
            }
            else
            {
                Console.WriteLine("Ouça com o plano Plus");
            }
            Console.WriteLine();
        }
    }
}


