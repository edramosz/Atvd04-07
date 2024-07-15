using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão2
{
    public class Animal
    {
        private string Nome { get; set; }
        private int Idade { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public Animal(string nome, int idade) 
        { 
            Nome = nome;
            Idade = idade;
        }
        public void RegistrarInformacoesAdicionais()
        {
            Console.WriteLine("Diga o peso.");
            Peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Diga a altura.");
            Altura= double.Parse(Console.ReadLine());
        }
        public virtual void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}\nIdade: {Idade}");
        }
        public void Comer()
        {
            Console.WriteLine("Comendo...");
        }
        public void Dormir()
        {
            Console.WriteLine("Dormindo...");
        }
    }
}
