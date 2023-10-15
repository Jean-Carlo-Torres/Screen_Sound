using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliar Álbum");
        Console.Write("Insira o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine("Agora digite o nome do álbum que deseja avaliar:");
            Console.Write("Álbum: ");
            string nomeDoAlbum = Console.ReadLine()!;
            if (banda.Albuns.Any(a => a.Nome.Equals(nomeDoAlbum)))
            {
                Album album = banda.Albuns.First(a => a.Nome.Equals(nomeDoAlbum));
                Console.WriteLine($"Digite uma nota de 1 a 10 para o álbum {nomeDoAlbum}!");
                Console.Write("Nota: ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                album.AdicionarNota(nota);
                Console.WriteLine($"Avaliação da banda {nomeDoAlbum} finalizada!");
                Thread.Sleep(2000);
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"O álbum  {nomeDoAlbum} não foi encontrada!");
                Console.WriteLine("\nDigite uma tecla para voltar ao menu");
                Console.ReadKey();
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("\nDigite uma tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }
    }
}