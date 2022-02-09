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
            double peso, altura, imc, resultado;
            Console.WriteLine("Entre com sua altura");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com seu peso");
            peso = double.Parse(Console.ReadLine());
            imc = peso / (altura * altura);
            resultado = imc * 1000;
            if (resultado < 20)
                Console.WriteLine("Voce esta abaixo do peso, seu imc é :{0:f}", resultado);
            else 
                if ( resultado <=20 || resultado < 25)
                Console.WriteLine("Voce esta no peso ideal, Parabens, seu imc é :{0:f}", resultado);
            else
                Console.WriteLine("Voce esta acima do peso, seu imc é :{0:f}", resultado);
            Console.ReadKey();
            






        }
    }
}
