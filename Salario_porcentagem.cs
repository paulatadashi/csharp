using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, c;
            string x, b;
            Console.WriteLine("Informe seu nome");
            x = Console.ReadLine();
            Console.WriteLine("Informe seu salario atual");
            a = double.Parse(Console.ReadLine());
            if (a <= 800)
            {
                b = "15%";
                c = (a * 0.15) + a;
                Console.WriteLine("Nome : {0}, % de aumento {1}, salario atual {2}, novo salario {3}", x, b, a, c);

            }
            else

            {
                if (a <= 1000)
                {
                    b = "12%";
                    c = (a * 0.12) + a;
                    Console.WriteLine("Nome : {0}, % de aumento {1}, salario atual {2}, novo salario {3}", x, b, a, c);



                }

                else
                {
                    if (a <= 1200)
                    {
                        b = "10%";
                        c = (a * 0.10) + a;
                        Console.WriteLine("Nome : {0}, % de aumento {1}, salario atual {2}, novo salario {3}", x, b, a, c);
                    }
                    else
                    {
                        b = "7%";
                        c = (a * 0.07) + a;
                        Console.WriteLine("Nome : {0}, % de aumento {1}, salario atual {2}, novo salario {3}", x, b, a, c);
                    }


                }


            }


            Console.ReadKey();



        }

    }
}




