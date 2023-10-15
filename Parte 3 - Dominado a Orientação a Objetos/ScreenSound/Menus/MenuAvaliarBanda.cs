using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuAvaliarBanda : Menu
{

    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliar banda");
        Console.Write("Insira o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"Digite uma nota de 1 a 10 para a banda {nomeDaBanda}!");
            Console.Write("Nota: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            banda.AdicionarNota(nota);
            Console.WriteLine($"Avaliação da banda {nomeDaBanda} finalizada!");
            Thread.Sleep(4000);
            Console.Clear();
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