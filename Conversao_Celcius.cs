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

            double c, b, f;
            Console.WriteLine("Digite o valor em celcius:");
            c = double.Parse(Console.ReadLine());
            f = ((c * 1.8) + 32);
            Console.WriteLine("Valor em Fahrenheit é :{0}", f);
            Console.ReadKey();
        }
        
    }    
}
