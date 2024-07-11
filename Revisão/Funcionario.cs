using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão
{
    public class Funcionario : Pessoa
    {
        private int Matricula { get; set; }
        private string PlacaVeiculo { get; set; }

        public int RetornaMatricula()
        {
            Console.WriteLine("Diga o número da matrícula.");
            Matricula = int.Parse(Console.ReadLine());
            return Matricula;
        }
        public bool VerificarVeiculo(Automovel a)
        {
            Console.WriteLine(a.Marca +"\n" + a.Modelo + "\n" + a.Cor + "\n" + a.Placa);
            if (PlacaVeiculo.Length == 7) 
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
