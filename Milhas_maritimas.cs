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
            double Q, M;
            Console.WriteLine("Digite em Milhas Maritimas M:");
            M = double.Parse(Console.ReadLine());
            Q = M * 1852;
            Console.WriteLine("O valor em quilometro é :{0}", Q);
            Console.ReadKey();
        }
    }    
}