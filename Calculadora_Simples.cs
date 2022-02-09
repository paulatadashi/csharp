using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, opção;
            do
            {
                menu();
                opção = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o primeiro numero");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o segundo numero");
                b = int.Parse(Console.ReadLine());

                switch (opção)
                {

                    case 1:
                        Console.WriteLine("A soma é {0}", soma(a, b));

                        break;

                    case 2:
                        Console.WriteLine("A subtração é : {0}", subtracao(a,b));
                        break;

                    case 3:
                        Console.WriteLine(" A divisão é {0}", divisao(a, b));
                        break;

                    case 4:
                        Console.WriteLine("A Multiplicação é {0}", multiplicação(a, b));
                        break;

                }

                Console.ReadKey();



            } while (opção != 5);

        }

        static void menu()
        {
            Console.Clear();
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtracao");
            Console.WriteLine("3. Multiplica");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("5. Sair");
            Console.WriteLine("=========================================");
            Console.WriteLine("Informe sua opção");
        }

        static int soma(int n1, int n2)

        {
            return n1 + n2;

        }

        static int subtracao(int n1, int n2)
        {
        return n1 - n2;    
        }

       static int divisao(int n1, int n2)
        {
            if (n2 == 0)
            {
                return 0;
            }
            else
                return n1 / n2;
        }

    static int multiplicação(int n1, int n2)
        {
            return n1 * n2;

        }

         
    }

}
    
