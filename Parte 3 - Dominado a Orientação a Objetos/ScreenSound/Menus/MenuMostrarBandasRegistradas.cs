using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuMostrarBandasRegistradas : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Lista das bandas registradas");
        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }
        Console.WriteLine("\nDigite uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();
    }
}