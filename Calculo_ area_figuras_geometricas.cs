using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, w, z;
            int op1;
            Console.WriteLine("Calculo de area de figuras geometricas");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("1. Quadrado");
            Console.WriteLine("2. Retangulo");
            Console.WriteLine("3. Triangulo");
            Console.WriteLine("4. Trapezio");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Sua opção [1-4]:");
            op1 = int.Parse(Console.ReadLine());
            if (op1 == 1)
            {
                Console.WriteLine("Informe o valor do lado");
                x = double.Parse(Console.ReadLine());
                y = (x * x);
                Console.WriteLine("A area da figura é de: {0:#00} m2", y);

            }
            else
            {
                if (op1 == 2)
                {
                    Console.WriteLine("Informe o lado maior");
                    x = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a altura");
                    y = double.Parse(Console.ReadLine());
                    z = (x * y) / 2;
                    Console.WriteLine("A area do quadrado é de: {0:#00} m2", z);

                }

                else
                {
                    if (op1 == 3)
                    {
                        Console.WriteLine("Informe o valor da base");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine("Informe a altura");
                        y = double.Parse(Console.ReadLine());
                        z = (x * y) / 2;
                        Console.WriteLine("A area do quadrado é de: {0:#00} m2", z);
                    }

                    else
                    {
                        if (op1 == 4)
                        {
                            Console.WriteLine("Informe o valor maior da base");
                            x = double.Parse(Console.ReadLine());
                            Console.WriteLine("Informe o valor menor da base");
                            y = double.Parse(Console.ReadLine());
                            Console.WriteLine("Informe a altura");
                            w = double.Parse(Console.ReadLine());
                            z = ((x + y) * w / 2);
                            Console.WriteLine("A area do quadrado é de: {0:#00} m2", z);

                        }
                    }
                }
            }

            Console.ReadKey();

        }

    }
}