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

            double x, y, r;
            Console.WriteLine("Valor de x:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor de y:");
            y = double.Parse(Console.ReadLine());
            r =Math.Exp (y* Math.Log(x));
            Console.WriteLine("{0} elevado a {1} = {2}", x, y, r);
            Console.ReadKey();


        }
        
    }     
}
