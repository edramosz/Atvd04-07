using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public bool Contatar()
        {
            Console.WriteLine("Usuário contatado com sucesso.");
            return true;
        }
    }
}
