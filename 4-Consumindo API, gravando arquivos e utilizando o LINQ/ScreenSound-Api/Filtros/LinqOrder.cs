using ScreenSound_Api.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_Api.Filtros
{
    internal class LinqOrder
    {
        public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
        {
            var artistasOrdenados = musicas.OrderBy(artista => artista.Artista).//ordena as músicas com base no artista (mas ai tem duração,nome...)
                Select(musica => musica.Artista). //usamos o Select para pegar só os Artistas.
                Distinct(). //tira o que é repitido
                ToList(); //vai colocar em uma lista de Strings.
            Console.WriteLine("Lista de artistas ordenados: ");
            foreach (var artista in artistasOrdenados)
            {
                Console.WriteLine($"- {artista}");
            }

        }
    }
}
