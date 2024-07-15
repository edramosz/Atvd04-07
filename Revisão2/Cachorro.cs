using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Revisão2
{
    public class Cachorro : Animal
    {
        private string Raca { get; set; }
        public Cachorro(string nome, int idade, string raca)
            : base(nome, idade);
        {
            Raca = raca;
        }
        
        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine($"Raça: {Raca}");
        }
        public void Latir()
        {
            Console.WriteLine("Latindo...");
        }
    }
}
