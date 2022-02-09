using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            double ag = 0, se = 0, co = 0, tg = 0, sc = 0, ra = 0;
            Console.WriteLine("Entre com os valores do angulo");
            ag = double.Parse(Console.ReadLine());
            ra = (ag * Math.PI) / 180;
            se = Math.Sin(ra);
            co = Math.Cos(ra);
            tg = Math.Tan(ra);
            sc = 1 / co;
            Console.WriteLine(" O valor das funções Seno, Cosseno, Tangente e Secante é, respectivamente : /nSeno:{0}/nCosseno:[1}/nTangente:{2}/nSecante{3}", se.ToString(), co.ToString(), tg.ToString(), sc.ToString());
            Console.ReadKey();
            


        }
    }
}
