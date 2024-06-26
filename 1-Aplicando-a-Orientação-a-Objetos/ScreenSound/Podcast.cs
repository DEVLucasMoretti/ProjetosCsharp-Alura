using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Podcast
    {
        private List<Episodio> episodios = new();

        public Podcast( string nome, string host)
        {
            Nome = nome;
            Host = host;
        }

        public string Host { get;  }
        public string Nome { get;  }
        public int TotalEpisodios => episodios.Count;

        public void AdicionarEpsodio(Episodio episodio)
        {
            episodios.Add(episodio);
        }

        public void ExibirDetalhes()
        {
            Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");
            foreach(Episodio episodio in episodios.OrderBy(e => e.Ordem))
            {
                Console.WriteLine(episodio.Resumo);
            }
            Console.WriteLine($"\n\nEste podcast possui {TotalEpisodios} episódios");
        }


    }
}
