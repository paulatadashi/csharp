using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            circulo JP = new circulo();

            Console.WriteLine("Digite o diametro do circulo:");
            JP.Diametro = double.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Diametro:{0} | Raio:{1}", JP.Diametro, JP.Raio);
            Console.WriteLine("Área: {0} | Circuferencia: {1}", JP.CalcularArea(), JP.CalcularCircuferencia());
            Console.ReadKey();
        }
    }
}
