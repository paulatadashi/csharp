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
            double altura, raio, volume;
            Console.WriteLine("Informe o valor da altura");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor do raio");
            raio = double.Parse(Console.ReadLine());
            volume = ((Math.PI * raio * raio) * altura) / 3;
            Console.WriteLine(" O volume do cone vale : " + volume);
            Console.ReadKey();
            


        }
    }
}
