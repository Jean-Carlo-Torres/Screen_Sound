using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScreenSound.Models;

namespace ScreenSound.Menus
{
    internal class MenuSair : Menu
    {
        public override void Executar(Dictionary<string, Banda> bandasRegistradas)
        {
            Console.WriteLine("Obrigado por utilizar o ScreenSound!");
        }
    }
}