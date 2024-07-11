using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisão
{
    public class Automovel
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }

        public Automovel(string marca, string modelo, string cor, string placa)
        {
            Marca = marca;
            Modelo = modelo;
            Cor = cor;
            Placa = placa;
        }
    }
}
