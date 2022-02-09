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
            double V1, V2, V3, V4, M;
            Console.WriteLine("Digite o valor do V1:");
            V1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do V2:");
            V2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do V3:");
            V3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do V4:");
            V4 = double.Parse(Console.ReadLine());
            M = (V1 + V2 + V3 + V4) / 4;
            Console.WriteLine(" O valor da Média é :{0}°", M);
            Console.ReadKey();
        }
    }    
}