using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.DesafioHoraPratica
{
    internal class Conta
    {
        public Conta(string nome, string artista, string duracao, bool disponivel)
        {
            Nome = nome;
            Artista = artista;
            Duracao = duracao;
            Disponivel = disponivel;
        }

        public string Nome { get; set; }
        public string Artista { get; set;}
        public string Duracao { get; set;}
        public bool Disponivel { get; set;}                                          
        public string DescricaoResumida =>
            $"O nome do artista é {Nome} e da banda é {Artista}";


        public bool ExibirDisponibilidade(bool value)
        {
            return Disponivel = value;
        }

        public void ExibirFichaDetalhada()
        {
            if (Disponivel == true)
            {
                Console.WriteLine($"Cantor: {Nome}\n\rBanda:{Artista}\n\rDuração:{Duracao}\n\rDisponibilidade: Disponível");
            }
            else
            {
                Console.WriteLine($"Cantor: {Nome}\n\rBanda:{Artista}\n\rDuração:{Duracao}\n\rDisponibilidade: Indisponível");
            }

        }


    }
}
