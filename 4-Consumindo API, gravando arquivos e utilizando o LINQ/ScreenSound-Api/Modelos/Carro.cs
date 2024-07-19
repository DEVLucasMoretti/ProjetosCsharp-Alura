using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ScreenSound_Api.Modelos
{
    internal class Carro
    {
        [JsonPropertyName("marca")]
        public string? Marca { get; set; }
        [JsonPropertyName("modelo")]
        public string? Modelo { get; set; }
        [JsonPropertyName("transmissao")]
        public string? Transmissao { get; set; }

        public void ExibirFichaResumidaCarro()
        {
            Console.WriteLine($"O Carro {Modelo}, da marca {Marca}, tem sua transmissão do tipo {Transmissao}");
        }

    }
}
