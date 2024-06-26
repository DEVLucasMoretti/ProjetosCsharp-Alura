using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound
{
    internal class Musica
    {
        //Contrutor
        public Musica(Banda artista, string nome)
        {
            Artista = artista;
            Nome = nome;
        }

        public string Nome { get; }
        public Banda Artista { get; }
        public int Duracao {  get; set; }
        public bool Disponivel {  get; set; }
        /*
        public string DescricaoResumida 
        {
            get 
            {
                return $"A música {Nome} pertence a banda {Artista}"; 
            }
        }
        */
        //Em vez disso resumimos o get dessa maneira:
        public string DescricaoResumida =>
            $"A música {Nome} pertence a banda {Artista}";
        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Artista: {Artista.Nome}");
            Console.WriteLine($"Duração: {Duracao}");
            if (Disponivel) { Console.WriteLine("Disponivel no plano"); }
            else { Console.WriteLine("Adquira o plano Plus+"); }
        }

    }

}