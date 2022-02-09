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

            int f1 = 0, f2 = 0, f3 = 0, f4 = 0, f5 = 0, i, x, porc1, porc2, porc3, porc4, porc5;

            for (i = 1; i <= 15; i++)
            {
                Console.WriteLine("Informe a {0}° idade:", i);
                x = int.Parse(Console.ReadLine());
                if (x >= 1 && x <= 15)
                    f1++;
                else
                {

                    if (x >= 16 && x <= 15)
                        f2++;
                    else
                        if (x >= 31 && x <= 45)
                        f3++;
                    else
                        if (x >= 46 && x <= 60)
                        f4++;
                    else
                        f5++;
                }

            }

            porc1 = f1 * 100 / 15;
            porc2 = f2 * 100 / 15;
            porc3 = f3 * 100 / 15;
            porc4 = f4 * 100 / 15;
            porc5 = f5 * 100 / 15;

            Console.WriteLine("Quantidade de pessoas por faixa etaria:\n01 a 15 anos: {0} = {1}%\n16 a 30 anos: {2} = {3}%\n31 a 45 anos: {4} = {5}%\n46 a 60 anos: {6} = {7}%\nAcima de 60 anos: {8} = {9}%", f1, porc1, f2, porc2, f3, porc3, f4, porc4, f5, porc5);

            Console.ReadKey();
            

        }

    }
}
