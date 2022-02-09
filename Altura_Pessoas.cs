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
            int i, media = 0, homem = 0;
            double altura, alt = 0, y = 0, mediaf = 0, maior = 0;
            string sexo;
            for (i = 1; i <= 15; i++)
            {
                Console.WriteLine("Informe a altura {0} pessoa", i);
                altura = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o sexo da {0} pessoa [M/F]", i);
                sexo = Console.ReadLine();
                if (alt > altura)
                    maior = alt;
                else
                    maior = altura;
                if (sexo == "f")
                {
                    y += altura;
                    media++;
                }
                else
                    homem++;
                alt = maior;
            }

            mediaf = y / media;
                Console.WriteLine("A maior altura do grupo é {0}\n A media de altura das mulheres é: {1}\nO numero de homens e media de altura das mulheres é: {1}\nO numero de homens é {2}", maior, mediaf, homem);
            Console.ReadKey();




        }

    }
}
