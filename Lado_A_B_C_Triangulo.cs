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
            Console.WriteLine("Entre com o lado A do triangulo");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o lado B do triangulo");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o lado C do triangulo");
            c = int.Parse(Console.ReadLine());
            if (a + b > c && b + c > a && a + c > b)
                if (a == b && a == c)
                {
                    Console.WriteLine("Seu triangulo é equilatero");
                }
                else
                    if (a == b || b == c || c == a)
                {
                    Console.WriteLine("Seu triangulo é isoceles");
                }
                else
                {
                    Console.WriteLine("Seu triangulo é escaleno");
                }
            else
                Console.WriteLine("Triangulo impossivel");
            Console.ReadKey();








        }
    }
}
