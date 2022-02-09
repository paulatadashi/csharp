using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            teste f = new teste();
            Console.WriteLine("Informe o id do funcionario");
            f.Id_funcionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do funcionario");
            f.Nome = Console.ReadLine();
            Console.WriteLine("Informe o cargo");
            f.Cargo = Console.ReadLine();
            Console.WriteLine("Informe o cpf");
            f.Cpf = Console.ReadLine();
            Console.WriteLine("informe o valor da hora trabalhada");
            f.Valor_hora = double.Parse(Console.ReadLine());
            Console.WriteLine("Numero de horas trabalhdas");
            f.Qtd_horas = double.Parse(Console.ReadLine());
            Console.WriteLine("Numero de dependentes");
            f.Qtd_dependentes = double.Parse(Console.ReadLine());

            //exibir dados

            Console.WriteLine("=========================================");
            Console.WriteLine("Id do funcionario : {0}", f.Id_funcionario);
            Console.WriteLine("Nome {0}", f.Nome);
            Console.WriteLine("Cargo {0}", f.Cargo);
            Console.WriteLine("Cpf {0}", f.Cpf);
            Console.WriteLine("Valor da hora trabalhada: {0}", f.Valor_hora.ToString("N2"));
            Console.WriteLine("Quantidade de horas trabalhadas: {0}", f.Qtd_horas);
            Console.WriteLine("Numero de dependentes: {0}", f.Qtd_dependentes);
            Console.WriteLine("Imposto de renda: {0}", f.CalcularIR());
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")

        }
    }
}
