

using System.Text.Json.Serialization;

namespace ScreenSound_Api.Modelos;

internal class Musica
{
    private string[] Tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };



                              //Ele faz a ponte entre os nomes das propriedades da sua classe C# e os nomes dos campos no JSON que você está usando.
    [JsonPropertyName("song")]//[JsonPropertyName("id")] no id passamos o nome do campo que queremos no JSON 
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }
    [JsonPropertyName("key")]
    public int Key { get; set; }
    public string Tonalidade{ get
        {
            return Tonalidades[Key];
        }
    }
    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Duração em segundos: {Duracao/1000}");
        Console.WriteLine($"Gênero musical: {Genero}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");

    }

}
