using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            double z = 0;
            double resultado = 0;
            Console.WriteLine("Informe seu numero real");
            z = double.Parse(Console.ReadLine());
            resultado = z / 3;
            Console.WriteLine("A terceira parte é {0#00}", resultado);
            Console.ReadKey();
            }
    }
}
