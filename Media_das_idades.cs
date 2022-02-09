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
            int media, x, i = 0, y = 0;
            Console.WriteLine("Informe as idades (0 para sair)");
            do
            {
                Console.Write("");
                x = int.Parse(Console.ReadLine());
                if (x != 0)
                {
                    y += x;
                    i++;
                }

            } while (x != 0);
            media = y / i;
            Console.WriteLine("A media das idades é: {0}", media);
            Console.ReadKey();




        }

    }
}
