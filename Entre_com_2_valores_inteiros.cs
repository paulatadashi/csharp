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
            int a,b;

            Console.WriteLine("Entre com 2 valores inteiros");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (a < b)
                Console.WriteLine("O maior valor é de {0}", a);
            else
                if (a == b)
                Console.WriteLine("Os valores são iguais {0}, {1}", a, b);
            else
                Console.WriteLine("O maior valor é {0}", b);
            Console.ReadKey();


        }
    }
}
