using AluraC_Testes.Calculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraC_Testes
{
    internal class Quadrado : FormaGeometrica
    {
        public double Lado { get; set; }

        public Quadrado(double lado)
        {
            Lado = lado;
        }

        public override void CalcularArea()
        {
           double res = Lado * Lado;
            Console.WriteLine($"A Área do quadrado é {res}");
        }
        public override void CalcularPerimetro()
        {
            double res = 4 * Lado;
            Console.WriteLine($"A Perímetro do quadrado é {res}");
        }
    }
}
