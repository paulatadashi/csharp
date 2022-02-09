using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            double l1,l2,h,area;
            int opcao;

            // exibir menu

            Console.WriteLine("Calculo de area de figuras geometricas");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("1. Quadrado");
            Console.WriteLine("2. Retangulo");
            Console.WriteLine("3. Triangulo");
            Console.WriteLine("4. Trapezio");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Sua opção [1-4]:");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)

            {
                case 1:

                    Console.WriteLine("Informe o valor do lado");
                    l1 = double.Parse(Console.ReadLine());
                    area = 1 * 1;
                    Console.WriteLine("A area do quadrado é :{0}", area.ToString("N1"));
                    break;

                case 2:

                    Console.WriteLine("Informe o valor do lado1");
                    l1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o valor do lado2");
                    l2 = double.Parse(Console.ReadLine());
                    area = l1 * l2;
                    Console.WriteLine("A area do quadrado é :{0}", area.ToString("N1"));
                    break;

                case 3:

                    Console.WriteLine("Informe o valor da base");
                    l1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o valor da altura");
                    h = double.Parse(Console.ReadLine());
                    area = (l1 * h) / 2;
                    Console.WriteLine("A area do triangulo é: {0}", area.ToString("N1"));
                    break;

                case 4:

                    Console.WriteLine("Informe o valor do lado1");
                    l1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o valor do lado2");
                    l2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Informe o valor da altura");
                    h = double.Parse(Console.ReadLine());
                    area = ((l1 + l2) * h) / 2;
                    Console.WriteLine("A area do trapezio é : {0}", area.ToString("N1"));
                    break;
                    default:
                    Console.WriteLine("Opção Invalida");
                    break;


            }

            Console.ReadKey();
        }
    }
}
