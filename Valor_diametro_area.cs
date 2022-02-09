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

            double d, r, a;
            Console.WriteLine("Digite o valor do diametro:");
            d = double.Parse(Console.ReadLine());
            r = d / 2;
            a = Math.PI * (r * r);
            Console.WriteLine("Valor da area é :{0}", a);
            Console.ReadKey();
        }
        
    }    
}
