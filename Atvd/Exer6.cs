using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atvd
{
    public class Exer6
    {
        public int Operacao { get; set; }
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double resultado{ get; set; }
        public void EscolheOperacao()
        {
            Console.WriteLine("Diga a operação a ser feita.\n1 - Adição\n2 - Subtração\n3 - Multiplicação\n4 - Divisão");
            Operacao = int.Parse(Console.ReadLine());
            Console.WriteLine("Diga o número 1.");
            Num1= double.Parse(Console.ReadLine());
            Console.WriteLine("Diga o número 2.");
            Num2= double.Parse(Console.ReadLine());

            if(Operacao == 1 ) 
            { 
                resultado = Num1 + Num2;
                Console.WriteLine(resultado);
            }
            else if(Operacao == 2 )
            {
                resultado = Num1 - Num2;
                Console.WriteLine(resultado);
            }
            else if(Operacao == 3 )
            {
                resultado = Num1 * Num2;
                Console.WriteLine(resultado);
            }
            else if(Operacao==4 )
            {
                resultado = Num1 / Num2;
                Console.WriteLine(resultado);
            }
        }
    }
}
