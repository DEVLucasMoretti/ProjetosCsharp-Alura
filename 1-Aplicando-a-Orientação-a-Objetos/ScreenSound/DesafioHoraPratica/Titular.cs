using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.DesafioHoraPratica
{
    internal class Titular
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Titular(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

    }
}
