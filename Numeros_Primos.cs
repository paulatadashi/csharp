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
            int x, i, div = 0;
            string s;
            do
            {
                Console.WriteLine("Informe um numero:");
                x = int.Parse(Console.ReadLine());
                for (i = 1; i <= x; i++)
                {
                    if (x % i == 0)
                        div++;
                }

                if (div == 2)
                    Console.WriteLine("O numero é primo");
                else
                    Console.WriteLine("O numero não é primo");
                Console.WriteLine("Deseja repetir o processo?[S/N]");
                s = Console.ReadLine();
            } while (s == "S" || s == "s");
            Console.ReadKey();






        }

    }
}
