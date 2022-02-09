using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            double H, B, A;

            Console.WriteLine("Digite o valor da base");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da Altura");
            H = double.Parse(Console.ReadLine());
            A = H * B;
            Console.WriteLine("Valor da area é {0}°", A);
            Console.ReadKey();

        }
    }
}
