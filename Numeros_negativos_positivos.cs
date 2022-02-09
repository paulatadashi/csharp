using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, neg = 0, pos = 0, somaf;
            Console.WriteLine("Informe uma lista de numeros positivos e negativos (0 para finalizar)");
            do
            {
                Console.WriteLine("");
                x = int.Parse(Console.ReadLine());
                if (x < 0)
                    neg += x;
                else
                    pos += x;
                somaf = neg + pos;
            } while (x != 0);

            Console.WriteLine("A soma dos numeros negativos é {0}\nA soma dos números positivos é: {1}\nA soma das parciais é: {2}", neg, pos, somaf);
            Console.ReadKey();



        }

    }
}
