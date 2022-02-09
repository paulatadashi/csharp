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

            double r, a, e, q, vl;
            Console.WriteLine("Digite o valor do raio da esfera:");
            r = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da aresta do cubo:");
            a = double.Parse(Console.ReadLine());
            e = (4 * Math.PI * Math.Pow(r, 3)) / 3;
            q = a * a * a ;
            vl = q - e;
            Console.WriteLine("Valor livre da área pe :{0}:", vl);
            Console.ReadKey();

        }
        
    }    
}
