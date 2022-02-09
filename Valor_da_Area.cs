using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            double Ar, A;
            Console.WriteLine("Digite o valor da Aresta");
            Ar = double.Parse(Console.ReadLine());
            A = Ar * Ar;
            Console.WriteLine("Valor da Area é : {0}°", A);
            Console.ReadKey();
        }
    }
}

