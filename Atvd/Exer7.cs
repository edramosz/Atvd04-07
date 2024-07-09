using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atvd
{
    public class Exer7
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int acao { get; set; }
        public void RealizarAcao()
        {
            Console.WriteLine("Escolha o primeiro número.");
            Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escolha o segundo número.");
            Num2 = int.Parse(Console.ReadLine());
            MostraMenu();
            if(acao == 1)
            {
                VerificaMultiplo();
                RealizarAcao();
            }
            else if(acao == 2)
            {
                VerificaPar();
                RealizarAcao();
            }
            else if(acao ==3)
            {
                VerificaMedia();
                RealizarAcao();
            }
            
        }
        public void MostraMenu()
        {
            Console.WriteLine("MENU\n1 - Verificar se um dos números é ou não múltiplo do outro.\n2 - Verificar se os dois números lidos são pares." +
                "\n3 - Verificar se a média dos dois números é maior ou igual a 7.\n4 - Sair" );
            acao = int.Parse(Console.ReadLine());
        }
        public void VerificaMultiplo()
        {
            if(Num1 >= Num2)
            {
                if (Num1 % Num2 == 0)
                {
                    Console.WriteLine("Os números são múltiplos.");
                }
                else
                {
                    Console.WriteLine("Os números não são múltiplos.");
                }
            }
            else
            {
                if (Num2 % Num1 == 0)
                {
                    Console.WriteLine("Os números são múltiplos.");
                }
                else
                {
                    Console.WriteLine("Os números não são múltiplos.");
                }
            }
            
        }
        public void VerificaPar()
        {
            if(Num1%2 == 0 && Num2%2 == 0)
            {
                Console.WriteLine("Os dois números são pares.");
            }
            else
            {
                Console.WriteLine("Os dois números não são pares.");
            }
        }
        public void VerificaMedia()
        {
            if(Num1 + Num2 / 2 >= 7)
            {
                Console.WriteLine("A média é maior que 7.");
            }
            else
            {
                Console.WriteLine("A média não é maior que 7.");
            }
        }
    }
}
