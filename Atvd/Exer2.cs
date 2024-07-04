using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atvd
{
    public class Exer2
    {
        double CotacaoDolar = 5.48;
        double Conversao = 0;

        public void ConversaoDolar(double dolar)
        {
            Conversao = dolar * CotacaoDolar;
            Console.WriteLine(Conversao);
        }
    }
}
