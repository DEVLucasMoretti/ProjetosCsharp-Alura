using AluraC_Testes.Calculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluraC_Testes
{
    internal class Circulo : FormaGeometrica
    {
        public Circulo(double raio)
        {
            Raio = raio;
        }

        public double Raio { get; set; }

        public override void CalcularArea()
        {
            double res = Math.PI * Math.Pow(Raio, 2);
            Console.WriteLine($"A Área do Círculo é {res}");
        }
        public override void CalcularPerimetro()
        {
            double res = 2 * Math.PI * Raio;
            Console.WriteLine($"O Perímetro do Círculo é {res}");

        }
    }
 
}
