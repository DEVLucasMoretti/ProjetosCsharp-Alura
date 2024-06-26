using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.DesafioHoraPratica
{
    internal class ContaBanco
    {
        public Titular Titular { get; set; }
        public decimal Agencia { get; set; }
        public int Numero { get; set; }
        public decimal Saldo { get; set; }
        public decimal Limite { get; set; }

  

        public void ExibirInformacoesConta()
        {
            Console.WriteLine($"Titular: {Titular.Nome} CPF: {Titular.Cpf} Ag: {Agencia} Conta: {Numero} ");
            Console.WriteLine($"Saldo Disponível: {Saldo} \nLimite: {Limite}");
        }
    }
}
