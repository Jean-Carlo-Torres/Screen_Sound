using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScreenSound.Models
{
    public class Episodio
    {
        private List<string> convidados = new();
        public Episodio(int ordem, string titulo, int duracao)
        {
            Ordem = ordem;
            Titulo = titulo;
            Duracao = duracao;
        }

        public int Ordem { get; }
        public string Titulo { get; }
        public int Duracao { get; }
        public string Resumo => $"{Ordem}. {Titulo} - {Duracao} minutos - {string.Join(", ", convidados)}";

        public void AdicionarConvidado(string convidado)
        {
            convidados.Add(convidado);
        }
    }
}