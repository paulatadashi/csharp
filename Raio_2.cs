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

            double r, h, v;
            Console.WriteLine("Digite o valor do Raio:");
            r = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura:");
            h = double.Parse(Console.ReadLine());
            v = (Math.PI * (r * r) * h / 3);
            Console.WriteLine("Volume do cone é:{0}", v);
            Console.ReadKey();
        }
        
    }    
}
