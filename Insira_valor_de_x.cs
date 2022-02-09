using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, r;
            Console.WriteLine("---Exe 1 B--");
            Console.WriteLine("Insira o valor de x:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor de y:");
            y = double.Parse(Console.ReadLine());
            z = Math.Sqrt(2 * y - Math.Pow(6, x)) / Math.Pow(3, 3);
            Console.WriteLine("O valor de x é :{0}", z.ToString("N2"));
            Console.ReadKey();
        }
    }
}
