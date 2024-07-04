using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atvd
{
    public class Produto 
    {
        public int Cod_peça { get; set; }
        public double Preço { get; set; }
        public Produto( int cod_peça, double preço)
        {
            Cod_peça = cod_peça;
            Preço = preço;
        } 
    }
}
