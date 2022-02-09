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
            double r, c, t;
            Console.WriteLine("Digite o valor da Resistencia:");
            r = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da corrente:");
            c = double.Parse(Console.ReadLine());
            t = r * c;
            Console.WriteLine("O valor da tensão é:{0}", t);
            Console.ReadKey();
        }
    }    
}
