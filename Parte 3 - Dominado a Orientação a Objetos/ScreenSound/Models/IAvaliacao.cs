using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenSound.Models;

internal interface IAvaliacao
{
    void AdicionarNota(Avaliacao nota);
    double Media { get; }
}