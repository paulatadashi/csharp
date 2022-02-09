using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            double ac, vl, tp, v, km;
            Console.WriteLine("Informe a sua aceleração");
            ac = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a sua velocidade inicial:");
            vl = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o tempo do percurso:");
            tp = double.Parse(Console.ReadLine());
            v = vl + (ac * tp);
            km = v * 3.6;
            if (v <= 40)
            {
                Console.WriteLine("Veiculo muito lento");
            }
            else
            {
                if (v <= 60)
                {
                    Console.WriteLine("Velocidade permitida");
                }
                else
                {
                    if (v <= 80)
                    {
                        Console.WriteLine("Velocidade de cruzeiro");
                    }
                    else
                    {
                        if (v <= 120)
                        {
                            Console.WriteLine("Veiculo rapido");
                        }
                        else
                        {
                            Console.WriteLine("Veiculo muito rapido");
                        }
                    }
                }
            }

            Console.WriteLine("Sua velocidade em km/h é de :{0}", km);

            Console.ReadKey();
        }                             
    }        
}

        
            
        
             