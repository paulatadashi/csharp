using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            double a, b, c, d, x1, x2;
            Console.WriteLine("Valor a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor b");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor c");
            c = double.Parse(Console.ReadLine());
            d = Math.Pow(b, 2) - 4 * a * c;
            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            x2 = (-b - Math.Sqrt(d)) / (2 * a);
                if (a == 0)
                Console.WriteLine("Não forma equação de segundo grau");
            else
                if (d < 0)
                Console.WriteLine("Não existem raizes reais");
            else
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("O valor de x1 é :{0:f}, e o valor de x2 é :{0:f}", x1, x2);
            }

            Console.ReadKey();
            }
    }
}
