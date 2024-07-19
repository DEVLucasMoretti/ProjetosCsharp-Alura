using System.Text.Json;
using ScreenSound_Api.Modelos;
using ScreenSound_Api.Filtros;

internal class Program
{
    private static async Task Main(string[] args)
    {
        using (HttpClient client = new HttpClient()) //solicita que queremos consumir algo
        {
            try
            {
                //Await ->le "pausa" a execução do código até que a tarefa (no caso, a requisição à API) seja concluída.
                //GetStringAsync -> Estamos pedindo as músicas da API
                string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
                Console.WriteLine(resposta);
                var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

                //LinqFilter.FiltrarMusicasEmCharp(musicas);

                //musicas[1].ExibirDetalhesDaMusica();
                //LinqFilter.FiltrarTodosGenerosMusicais(musicas);
                //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
                //LinqFilter.FiltarArtistasPorGeneroMusical(musicas,"hip hop");
                //LinqFilter.FiltarMusicasDeUmArtistas(musicas,"Post Malone");

                var musicasPreferidasDoLucas = new MusicasPreferidas("Lucas");
                musicasPreferidasDoLucas.AdicionarMusicasFavoritas(musicas[2]);
                musicasPreferidasDoLucas.AdicionarMusicasFavoritas(musicas[27]);
                musicasPreferidasDoLucas.AdicionarMusicasFavoritas(musicas[38]);
                musicasPreferidasDoLucas.AdicionarMusicasFavoritas(musicas[477]);
                musicasPreferidasDoLucas.AdicionarMusicasFavoritas(musicas[1996]);

                musicasPreferidasDoLucas.ExibirMusicasFavoritas();

                var musicasPreferidasDaIsabela = new MusicasPreferidas("Alisson");
                musicasPreferidasDaIsabela.AdicionarMusicasFavoritas(musicas[22]);
                musicasPreferidasDaIsabela.AdicionarMusicasFavoritas(musicas[33]);
                musicasPreferidasDaIsabela.AdicionarMusicasFavoritas(musicas[44]);
                musicasPreferidasDaIsabela.AdicionarMusicasFavoritas(musicas[6]);
                musicasPreferidasDaIsabela.AdicionarMusicasFavoritas(musicas[356]);

                musicasPreferidasDaIsabela.ExibirMusicasFavoritas();
                musicasPreferidasDaIsabela.GerarArquivoJson();


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Temos um problema: {ex.Message}");
            }

            //O bloco try-catch é essencial para lidar com erros em um programa.
            //Ele protege o código que pode gerar problemas, permitindo capturar e tratar as exceções que ocorrem.
            //Sem o try-catch, o programa poderia travar e mostrar mensagens de erro confusas para o usuário, travando o programa.

        }
    }
}