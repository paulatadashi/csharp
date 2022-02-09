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
            int x,y,z;
            double resultado = 0;
            Console.WriteLine("Calcule a area do retangulo");
            Console.WriteLine("Informe a base do retangulo");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o valor da altura");
            y = Convert.ToInt32(Console.ReadLine());
            resultado = (x * y);
            Console.WriteLine("A area do quadrado é de :{0}", resultado);
            Console.ReadKey();

        }
    }
}
