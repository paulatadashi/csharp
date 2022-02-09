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
            Console.WriteLine("Calcule a area de um quadrado");
            Console.WriteLine("=============================");
            Console.WriteLine("Informe o valor de sua aresta");
            x = Convert.ToInt32(Console.ReadLine());
            y = (x * x);
            Console.WriteLine("A area do seu quadrado é de :{0}");
            Console.ReadKey();
        }                             
    }        
}

        
            
        
             