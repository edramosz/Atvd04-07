using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atvd
{
    public class Vendedor 
    {
        public int ID { get; set; }
        public int Cod_peça { get; set; }
        public int Qtnd_venda { get; set; }
        public Vendedor(int id, int vendidos, int cod)
        {
            ID = id;
            Qtnd_venda = vendidos;
            Cod_peça = cod;
        }
    }
}
