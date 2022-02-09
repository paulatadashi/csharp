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

            double g, t, rad;
            Console.WriteLine("Digite o valor em Graus:");
            g = double.Parse(Console.ReadLine());
            rad = (g * Math.PI) / 180;
            Console.WriteLine("O valor  do seno é :{0}", Math.Sin(rad));
            Console.WriteLine("o valor do cosseno é :{0}", Math.Cos(rad));
            Console.WriteLine("O valor da tangente é :{0}", Math.Tan(rad));
            t = 1 / (Math.Cos(rad));
            Console.WriteLine("O valor da tangente é:{0}", t);
            Console.ReadKey();

        }
        
    }     
}
