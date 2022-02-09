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
            int x, i, j, div = 0, primo = 0;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe um numero:");
                x = int.Parse(Console.ReadLine());
                for (j = 1; j <= x; j++)
                {
                    if (x % j == 0)
                        div++;
                }

                if (div == 2)
                    primo++;
            }

            div = 0;
        

            Console.WriteLine(" Há {0} numeros primos", primo);


            Console.ReadKey();




        }

    }
}
