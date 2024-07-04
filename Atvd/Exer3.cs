using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atvd
{
    public class Exer3
    {
        public int ID { get; set; }
        public int Cod_peça { get; set; }
        public double Preço { get; set; }
        public int Qtnd_venda { get; set; }
        public double Comissao { get; set; }

        List<Produto> Produtos = new List<Produto>();
        List<Vendedor> Vendedores = new List<Vendedor>();
        public Exer3()
        {
            InicializarDados();
        }
        private void InicializarDados()
        {
            Produtos.Add(new Produto(1, 5.50));
            Produtos.Add(new Produto(2, 9));
            Produtos.Add(new Produto(3, 2));
            Produtos.Add(new Produto(4, 7));

            Vendedores.Add(new Vendedor(1, 200,2));
            Vendedores.Add(new Vendedor(2, 500, 1));
            Vendedores.Add(new Vendedor(3, 100, 3));
            Vendedores.Add(new Vendedor(4, 400, 4));
        }
        public void CalcularComissao()
        {
            Console.WriteLine("Qual seu id?");
            int id = int.Parse(Console.ReadLine());
            if (id < 0 || id > 4) 
            {
                Console.WriteLine("ID inválido!!!");
                CalcularComissao();
            }
            else {
                foreach (Vendedor i in Vendedores)
                {
                    if (i.ID == id)
                    {
                        Cod_peça = i.Cod_peça;
                        Qtnd_venda = i.Qtnd_venda;
                    }
                }
                foreach (Produto p in Produtos)
                {
                    if (p.Cod_peça == Cod_peça)
                    {
                        Preço = p.Preço;
                    }
                }
                Comissao = (Preço * Qtnd_venda) * 0.05;
                Console.WriteLine("Sua comissão será: " + Comissao);
            }
            
        }
    }
}
