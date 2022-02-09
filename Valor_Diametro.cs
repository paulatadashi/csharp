using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, A;
            Console.WriteLine("Digite o valor do diametro");
            R = double.Parse(Console.ReadLine());
            A = (4 * Math.PI * Math.Pow(R, 3)) / 3;
            Console.WriteLine("O volume é {0}°", A);
            Console.ReadKey();
        }
    }    
}