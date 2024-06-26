using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Album
    {
        private List<Musica> musicas = new List<Musica>();

        public Album(string nome)
        {
            Nome = nome;
        }

        public string Nome { get;  }
        public int DuracaoTotal =>
            musicas.Sum(m => m.Duracao);
        public void AdicionarMusica(Musica musica) 
        {
            musicas.Add(musica);
        }
        public void ExibirMusicasDoAlbum()
        {
            Console.WriteLine($"Lista de músicas do álbum {Nome}:");
            foreach (var musica in musicas) 
            {
                Console.WriteLine($"Músicas: {musica.Nome}");
            }
            Console.WriteLine($"Para ouvir o álbum inteiro você precisa de {DuracaoTotal} segundos ");
        }
    }
}
