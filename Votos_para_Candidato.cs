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
            int c1 = 0, c2 = 0, c3 = 0, c4 = 0, b = 0, n = 0, total, porcb = 0, porcn = 0;
            string voto;
            do
            {
                Console.WriteLine("Digite seu voto (0 para sair):");
                voto = Console.ReadLine();
                if (voto == "b" || voto == "n" || voto == "14" || voto == "46" || voto == "75" || voto == "87")
                {
                    if (voto == "14")
                        c1++;
                    else
                    {
                        if (voto == "46")
                            c2++;
                        else
                            if (voto == "75")
                            c3++;
                        else
                            if (voto == "87")
                            c4++;
                        else
                            if (voto == "b")
                            b++;
                        else
                            if (voto == "n")
                            n++;
                    }

                    total = c1 + c2 + c3 + c4 + b + n;
                    porcb = b * 100 / total;
                    porcn = n * 100 / total;
                }
                else
                    Console.WriteLine("Voto não computado por favor digite um valor válido");
            } while (voto != "0");

            Console.WriteLine("Total de votos do candidado 14:{0}\nTotal de votos do candidato 46: {1}\nTotal de votos do candidato 75: {2}\nTotal de votos do candidato 87:{3}\nTotal de votos em branco: {4}\nTotal de votos nulos: {5}\nPorcentagem de votos brancos: {6}%\nPorcentagem de votos nulos: {7}%", c1, c2, c3, c4, b, n, porcb, porcn);
            Console.ReadKey();
                  




        }

    }
}
