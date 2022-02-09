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
            double p1, p2, media = 5;
            Console.WriteLine("Informe a nota da P1");
            p1 = double.Parse(Console.ReadLine());
            // media = (p1+(2*p2)/3
            p2 = ((media * 3) - p1) / 2;
            Console.WriteLine("Precisa de no minimo {0} na p2 para ser aprovado", p2);
            Console.ReadKey();
        }
    }
}
