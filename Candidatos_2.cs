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
            int idade, f = 0, m = 0, idadet = 0, idadem = 0, m45 = 0, porcm = 0, f35 = 0, menor = 0, novaidade = 0;
            string sexo, exp;
            do
            {
                Console.WriteLine("Informe a idade ( 0 para sair)");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe o sexo [M/F]");
                sexo = Console.ReadLine();
                Console.WriteLine("Informe se há experiência anterior [S/N]:");
                exp = Console.ReadLine();
                if (idade != 0)
                {
                    if (sexo == "F")
                        f++;
                    else
                        m++;
                    if (sexo == "M" && exp == "S")
                    {
                        idadet += idade;
                        idadem += idadet / m;
                    }

                    if (sexo == "M" && idade < 35)
                    {
                        if (exp == "S")
                            f35++;
                    }

                    if (sexo == "F" && exp == "S")
                    {
                        if (idade > novaidade)
                            menor = novaidade;
                        else
                            menor = idade;
                        novaidade = idade;
                    }


                }
            } while (idade != 0);
        
                
                    Console.WriteLine("Número de candidatos do sexo feminino: {0}\nNumero de candidatos do sexo masculino {2}\nPorcentagem de homens com mais de 45 anos {3}\nNumero de mulheres com idade inferior a 35 anos experiencia: {5}", f, m, idadem, porcm, f35, menor);
                    Console.ReadKey();




                
            
        }
            
    }
}

    






        


    
