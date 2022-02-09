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
            int r;
            double resultado = 0,Pi = 3.14159;
            Console.WriteLine("Calculando a area de um triagulo a partir de sua base");
            Console.WriteLine("Informe a area de sua esfera");
            r = Convert.ToInt32(Console.ReadLine());
            resultado = Pi * (r * r);         
            Console.WriteLine("A area do quadrado é de :{0}", resultado);
            Console.ReadKey();

        }
    }
}
