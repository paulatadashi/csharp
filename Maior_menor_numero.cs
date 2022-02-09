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

            double a, b;
            Console.WriteLine("Maior numero (obs: digite numeros distintos)");
            Console.WriteLine("Digite o primeiro numero:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            b = double.Parse(Console.ReadLine());

            if (a > b)
                Console.WriteLine("O maior numero é :{0}", a);

            if (b > a)
                Console.WriteLine("O maior numero é :{0}", b);
            Console.ReadKey();

        }
        
    }     
}
