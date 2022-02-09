using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    public class Funcionario
    {
        private int id_funcionario;
        private string nome;
        private string cpf;
        private string cargo;
        private double valor_hora_trabalhada;
        private double qntd_horas_trabalhadas;
        private int qntd_dependentes;
        private double salario_bruto;
        private double imposto;

        public int Id_funcionario
        {
            set { id_funcionario = value; }
            get { return id_funcionario; }
        }

        public string Nome
        {
            set { nome = value; }
            get { return nome; }
        }
        public string Cpf
        {
            set { cpf = value; }
            get { return cpf; }
        }
        public string Cargo
        {
            set { cargo = value; }
            get { return cargo; }
        }      

        public double ValorHoraTrabalhada
        {
            set
            {
                if (value > 0)
                {
                  valor_hora_trabalhada = value;
                }
                else
                {
                    throw new Exception("O valor da hora trabalhada deve ser maior que zero.");
                }
            }
            get { return valor_hora_trabalhada; }           
        }

        public double HorasTrabalhadas
        {
            set
            {
                if (value > 0)
                {
                    qntd_horas_trabalhadas = value;
                }
                else
                {
                    throw new Exception("Horas trabalhadas tem que ser maior que zero.");
                }
            }
            get { return qntd_horas_trabalhadas; }
        }

        public int Dependente
        {
            set
            {
                if (value > 0)
                {               
                   if (value < 6)
                   {
                    qntd_dependentes = value;
                   }
                    else
                    {
                        throw new Exception("Maximo de 5 dependentes.");
                    }
                }
            }
            get { return qntd_dependentes; }
        }

        public double CalcularSalarioBruto()
        {
            salario_bruto = ((valor_hora_trabalhada * qntd_horas_trabalhadas) + (50.00 * qntd_dependentes));
            return salario_bruto;
        }

        public double CalcularIR()
        {
            if (salario_bruto < 2000)
            {
                imposto = 0;
                return imposto;
            }
            if (salario_bruto > 2001 && salario_bruto < 6000)
            {
                imposto = (salario_bruto * (0.15));
                return imposto;
            }
            else
            {
                imposto = (salario_bruto * (0.275));
                return imposto;
            }           
        }

        public double CalcularSalarioLiquido()
        {
            return salario_bruto - imposto;
        }
    }
}
