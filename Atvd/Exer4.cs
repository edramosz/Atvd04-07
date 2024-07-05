using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atvd
{
    public class Exer4
    {
        public double ValorA { get; set; }
        public double ValorB { get; set; }
        public double troca { get; set; }
        public void TrocarValores()
        {
            Console.WriteLine("Diga o valor A.");
            ValorA = double.Parse(Console.ReadLine());
            Console.WriteLine("Diga o valor B.");
            ValorB= double.Parse(Console.ReadLine());

            troca = ValorA;
            ValorA = ValorB;
            ValorB = troca;

            Console.WriteLine("Valor A trocado: " + ValorA);
            Console.WriteLine("Valor B trocado: " + ValorB);
        }
    }
}
