using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Terreno T = new Terreno();
                Console.WriteLine("Informe o valor da frente");
                T.Frente = double.Parse(Console.ReadLine());
                Console.WriteLine("Informe o valor da lateral");
                T.Lateral = double.Parse(Console.ReadLine());
                //exibir o resultado
                Console.WriteLine("Terreno: - Frente: {0} - Lateral {1}", T.Frente, T.Lateral);
                Console.WriteLine("Area {0} - Perímero {1}", T.CalcularArea(), T.CalcularPerimetro());
            }
            catch(Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            Console.ReadKey();
        }
    }
}
