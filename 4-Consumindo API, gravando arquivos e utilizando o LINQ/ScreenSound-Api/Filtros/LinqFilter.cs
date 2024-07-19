using ScreenSound_Api.Modelos;
using System.Linq;

namespace ScreenSound_Api.Filtros;

//LINQ (Language Integrated Query)
//Entendemos que podemos realizar uma ampla variedade de operações, como selecionar, filtrar,
//ordenar, projetar, agrupar e juntar dados de diferentes fontes, de forma fácil e eficiente

internal class LinqFilter
{
    public static void FiltrarTodosGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();

        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musicas => musicas.Genero!.Contains(genero)).OrderBy(musicas => musicas.Artista) //vai pegar as musicas que contem esse genêro
            .Select(musica => musica.Artista). //vai selecionar só os Artistas  relacionados gênero.
            Distinct().ToList(); //faz uma lista de strings de Artistas que tocam tal gênero.
        Console.WriteLine($"Exibindo os artistas do gênero musical {genero}");
        foreach(var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"-  {artista}");
        }
    }

    public static void  FiltarMusicasDeUmArtistas(List<Musica> musicas, string nomeDoArtista) 
    {
        var musicasDoArtista = musicas.Where(musicas => musicas.Artista!.Equals(nomeDoArtista)).OrderBy(musicas => musicas.Nome).Select(musicas => musicas.Nome).Distinct().ToList();
        Console.WriteLine($"\n\n{nomeDoArtista}\n");
        foreach(var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica}");
        }
    }

    internal static void FiltrarMusicasEmCharp(List<Musica> musicas)
    {
        var musicasEmCshap = musicas.Where(musica => musica.Tonalidade.Equals("C#")).Select(musica => musica.Nome).ToList();
        Console.WriteLine($"\nMúsicas em C#\n");
        foreach ( var musica in musicasEmCshap)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
