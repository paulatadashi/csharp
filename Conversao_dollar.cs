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

            double r, d;
            Console.WriteLine("Digite o valor em dolar:");
            d = double.Parse(Console.ReadLine());
            r = d / 3.1083;
            Console.WriteLine("O valor livre em dolar é: {0}", r);
            Console.ReadKey();

        }
        
    }     
}
