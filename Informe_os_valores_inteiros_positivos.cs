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

            int i = 0, x, maior = 0, menor = 0, n = 0;
            Console.WriteLine("Informe os valores inteiros e positivos (0 p/ sair)");
            do
            {
                i++;
                Console.WriteLine("Informe um {0}° valor:", i);
                x = int.Parse(Console.ReadLine());
                if (x < 0)
                    Console.WriteLine("Valor incorreto, informe um valor positivo");
                if (x > 0 && x != 0)
                {
                    if (x > n)
                        maior = x;

                    else
                        menor = x;
                }
                n = x;
            } while (x != 0);
            Console.WriteLine("Maior valor: {0}\nMenor valor:{1}", maior, menor);
            Console.ReadKey();



            

        }

    }
}
