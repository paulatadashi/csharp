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
            double esfera, cubo, volumelivre;
            Console.WriteLine("Informe o valor do raio:");
            esfera = Math.Pow(double.Parse(Console.ReadLine()), 3) * Math.PI * (3/4);
            Console.WriteLine("Informe o valor da aresta");
            cubo = Math.Pow(double.Parse(Console.ReadLine()), 3);
            volumelivre = cubo - esfera;
            Console.WriteLine("O volume livre vale : " + volumelivre);
            Console.ReadKey();

            


        }
    }
}
