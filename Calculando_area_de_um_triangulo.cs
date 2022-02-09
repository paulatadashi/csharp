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
            int x, y;
            double resultado = 0;
            Console.WriteLine("Calculando a area de um triangulo a partir de sua base e altura");
            Console.WriteLine("===============================================================");
            Console.WriteLine("Informe a base do triangulo");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe a area do seu triangulo");
            y = Convert.ToInt32(Console.ReadLine());
            resultado = (x * y) / 2;
            Console.WriteLine("A area do quadrado é de  : {0}", resultado);
            Console.ReadKey();
        }
    }
}
