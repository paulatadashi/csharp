using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, t, vi, k, vf;
            Console.WriteLine("Digite o valor da aceleração:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do tempo:");
            t = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da velocidade inicial:");
            vi = double.Parse(Console.ReadLine());
            k = (a / t) + vi;
            vf = k * 3.6;
            Console.WriteLine("Valor da velocidade final é:{0}", vf);

            Console.ReadKey();
        }
        
    }    
}
