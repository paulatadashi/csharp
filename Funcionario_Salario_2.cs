using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario JP = new Funcionario();
            Console.WriteLine("Digite seu ID:");
            JP.Id_funcionario = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu nome:");
            JP.Nome = Console.ReadLine();
            Console.WriteLine("Digite seu CPF: {0}", JP.Cpf);
            JP.Cpf = Console.ReadLine();
            Console.WriteLine("Digite seu cargo:{0}", JP.Cargo);
            JP.Cargo = Console.ReadLine();
            Console.WriteLine("Digite o valor da hora: ");
            JP.ValorHoraTrabalhada = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de horas trabalhada");
            JP.HorasTrabalhadas = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de dependentes");
            JP.Dependente = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("ID:{0}",JP.Id_funcionario);
            Console.WriteLine("Nome:{0}", JP.Nome.ToUpper());
            Console.WriteLine("CPF:{0}", JP.Cpf);
            Console.WriteLine("Cargo: {0}", JP.Cargo);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Seu salario Bruto é: R${0}", JP.CalcularSalarioBruto());
            Console.WriteLine("O imposto de renda a ser pago é: R${0}", JP.CalcularIR());
            Console.WriteLine("Seu salario liquido é: R${0}", JP.CalcularSalarioLiquido());

            Console.ReadKey();           
        }
    }
}
