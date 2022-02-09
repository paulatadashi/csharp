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

            double x, y, z, q, s, soma, d, troco;
            Console.WriteLine("Digite o valor do primeiro numero:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do segundo numero:");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do terceiro numero:");
            z = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do quartp numero:");
            q = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do quinto numero:");
            s = double.Parse(Console.ReadLine());
            soma = (x + y + z + q + s);
            Console.WriteLine("Digite o dinheiro:");
            d = double.Parse(Console.ReadLine());
            troco = d - soma;
            Console.WriteLine("o troco é :{0}", troco);
            Console.ReadKey();
        }
        
    }     
}
