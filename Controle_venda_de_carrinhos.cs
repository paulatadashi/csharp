using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[,] carrinho = new int[20, 2];
            int i, escolha ,opção, Aux = 0, QuantidadeSalgada = 0, QuantidadeDoce = 0, Valor = 0, pos = 0;

            do
            {
                Console.WriteLine("[ 1 ] Lançar venda");
                Console.WriteLine("[ 2 ] Mapa de faturamento");
                Console.WriteLine("[ 3 ] Carrinho que mais faturou");
                Console.WriteLine("[ 4 ] Carrinho que menos faturou");
                Console.WriteLine("[ 0 ] Sair do Programa");
                Console.WriteLine("-------------------------------------");
                Console.Write("Digite uma opção: ");
                opção = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (opção)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Digite o Numero do Carrinho: ");
                        escolha = int.Parse(Console.ReadLine());
                        escolha--;
                        i = 0;

                        Aux = carrinho[escolha, i];
                        Console.Write("Digite quantos pacotes de pipoca Doce: ");
                        carrinho[escolha, i] = int.Parse(Console.ReadLine());
                        Aux = Aux + carrinho[escolha, i];
                        carrinho[escolha, i] = Aux;

                        i++;

                        Aux = carrinho[escolha, i];
                        Console.Write("Digite quantos pacotes de pipoca Salgada: ");
                        carrinho[escolha, i] = int.Parse(Console.ReadLine());
                        Aux = Aux + carrinho[escolha, i];
                        carrinho[escolha, i] = Aux;

                        Console.Write("Venda Registrada com Sucesso");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                       
                        Console.WriteLine("|  Carrinho  |    Pipoca doce         |        Pipoca Salgada   |      Total       |"); 
                        Console.WriteLine("|            |  Quantidade|    Valor  |    Quantidade |   Valor |                  |");
                        Console.WriteLine("|==================================================================================|");
                        for (escolha = 0; escolha < 20; escolha++)
                        {
                            i = 0;
                            Console.WriteLine("|      {0,2}    |    R${1},00   |   {2,4}   |    R${3},00     |   {4,4}    |    R${5,2},00     |", escolha + 1, carrinho[escolha, i], carrinho[escolha, i] * 2, carrinho[escolha, i + 1], carrinho[escolha, i + 1] * 3, (carrinho[escolha, i] * 2) + (carrinho[escolha, i + 1] * 3));
                        }
                        Console.WriteLine("|==================================================================================|");
                        for (escolha = 0; escolha < 20; escolha++)
                        {
                            i = 0;
                            QuantidadeDoce = QuantidadeDoce + carrinho[escolha, i];
                            i++;
                            QuantidadeSalgada = QuantidadeSalgada + carrinho[escolha, i];
                        }
                        Console.WriteLine("|Total Geral |    {0}   |   R${1,4},00   |    {2}     |   R${3,4},00    |     R${4},00     |", QuantidadeDoce, QuantidadeDoce * 2, QuantidadeSalgada, QuantidadeSalgada * 2, (QuantidadeSalgada * 2) + (QuantidadeDoce * 3));
                       
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Aux = 0;
                        for (escolha = 0; escolha < 20; escolha++)
                        {
                            Valor = 0;

                            i = 0;
                            Valor = Valor + (carrinho[escolha, i] * 2);

                            i++;
                            Valor = Valor + (carrinho[escolha, i] * 3);

                            if (Valor > Aux)
                            {
                                Aux = Valor;
                                pos = escolha;
                            }
                        }
                        Console.WriteLine("O Valor Maior é {0} No Carrinho {1}", Aux, pos + 1);
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Aux = 9999999;
                        for (escolha = 0; escolha < 20; escolha++)
                        {
                            Valor = 0;
                            i = 0;
                            Valor = Valor + (carrinho[escolha, i] * 2);
                            i++;
                            Valor = Valor + (carrinho[escolha, i] * 3);
                            if (Valor < Aux && Valor != 0)
                            {
                                Aux = Valor;
                                pos = escolha;
                            }
                        }
                        Console.WriteLine("O Valor Menor é {0} No Carrinho {1}", Aux, pos + 1);
                        Console.ReadKey();
                        break;
                    default:            
                        break;
                }
                Console.Clear();  
            }
            while (opção != 0);
        } 

    }
}
