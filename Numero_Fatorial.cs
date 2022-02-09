using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, x;
            Console.WriteLine("Informe o valor inteiro:");
            x = int.Parse(Console.ReadLine());
            n = x;
            for (i = n - 1; i >= 1; i--)
                n *= i;
            Console.WriteLine("O fatorial de {0}! é: {1}", x, n);
            Console.ReadKey();




        }

    }
}
