using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class teste
    {
        // variaveis internas / campos / fields
        private int id_funcionario;
        private string nome;
        private string cargo;
        private double valor_hora;
        private double qtd_horas;
        private double qtd_dependentes;
        private string cpf;

        //propriedades / properties

        public int Id_funcionario
        {
            set
            {
                id_funcionario = value;
            }
            get
            {
                return id_funcionario;
            }
        }

        public string Nome
        {
            set
            {
                nome = value;
            }
            get
            {
                return nome;
            }
        }

        public string Cargo
        {
            set
            {
                cargo = value;
            }
            get
            {
                return cargo;
            }
        }


        public double Valor_hora
        {
            set
            {
                valor_hora = value;
            }
            get
            {
                return valor_hora;
            }
        }
        public double Qtd_horas
        {
            set
            {
                if (value > 0)
                    qtd_horas = value;
                else
                    throw new Exception("Quantidade de horas invalida");
            }
            get
            {
                return qtd_horas;
            }

        }
            public double Qtd_dependentes
            {
                set
                {
                    if (value < 0 )
                        qtd_dependentes = 5;
                        throw new Exception ("Quantidade de dependentes invalidas");
                    else
                      qtd_dependentes = value;
                }
                get 
                {
                    return qtd_dependentes;
                }

            }
        public string Cpf
        {
            set 
            {
                
                cpf = value;
            }
            get
            {
                return cpf;
            }
        }
            
        public double CalcularSalarioBruto()
        {
            return valor_hora * qtd_horas + (50 * qtd_horas);
        }

        public double CalcularIR()
        {
            double sal = CalcularSalarioBruto();
            if ( sal > 2000)
                return 0;
            else
                if (sal <=6000)
                    return sal * 15/100;
                else
                    return 

        }
        public double CalcularSalarioLiquido()
        {


        }
            


        }
    }
}


                    
                
            
        

    

