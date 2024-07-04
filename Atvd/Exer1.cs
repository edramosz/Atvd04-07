using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atvd
{
    public class Exer1
    {
        public int EstoqueMedio { get; set; }
        public void CalcularEstoque(int qtnd_min, int qtnd_max)
        {
            EstoqueMedio = (qtnd_min + qtnd_max) / 2;
            Console.WriteLine("Estoque Médio é: " + EstoqueMedio);
        }
    }
}
