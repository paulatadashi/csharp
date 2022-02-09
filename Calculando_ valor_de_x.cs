using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x;
            Console.WriteLine("Calculando o valor de x:");
            Console.WriteLine("Informe o valor de a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de c:");
            c = double.Parse(Console.ReadLine());
            x = a + (b / c);
            Console.WriteLine("O valor de x é :{0}", x);
            Console.ReadKey();
        }
    }
}
