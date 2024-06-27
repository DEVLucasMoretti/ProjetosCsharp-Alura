using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Modelos
{
    internal class Avaliacao
    {
        public Avaliacao(int nota)
        {
            Nota = nota;
        }
        public int Nota { get; set; }

        public static Avaliacao Parse(string texto)
        {
            int nota = int.Parse(texto);
            return new Avaliacao(nota);
        }

    }   
}
