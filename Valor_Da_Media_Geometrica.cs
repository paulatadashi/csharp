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
            double v1, v2, m;
            Console.WriteLine("Digite o valor v1:");
            v1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor v2:");
            v2 = double.Parse(Console.ReadLine());
            m = Math.Sqrt(v1 * v2);
            Console.WriteLine("o valor da media geometrica é :{0}", m);
            Console.ReadKey();
        }
    }    
}