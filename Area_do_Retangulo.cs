using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("area do retangulo:");
            Console.WriteLine("Digite um valor a ser atribuido a base:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para ser atribuido a altura:");
            b = double.Parse(Console.ReadLine());
            c = a * b;
            if (c < 100)
                Console.WriteLine("terreno grande");
            Console.ReadKey();
        }
    }
}
