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
            int a, b, c;
            Console.WriteLine(" Entre com 3 valores inteiros");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (b >= c && a >= c)
                Console.WriteLine(" O maior valor é {0}", a);
            else 
                if (b >=c && b >=a)
                Console.WriteLine(" O maior valor é {0}", b);
            else
                Console.WriteLine(" O maior valor é {0}", c);
            Console.ReadKey();





        }
    }
}
