using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Terreno
    {
        private double frente;
        private double lateral;

        public double Frente
        {
            get { return frente; }
            set
            {
                if (value > 0)
                    frente = value;
                else
                    throw new Exception("Medida da frente inválida");
            }
        }
        public double Lateral
        {
            get { return lateral; }
            set
            {
                if (value > 0)
                    lateral = value;
                else
                    throw new Exception("Medida da Lateral Inválida");
            }
        }




        //metodos
        public double CalcularArea()
        {
            return frente * lateral;
        }

        public double CalcularPerimetro()
        {
            return frente + frente + lateral + lateral;
        }
    }
}
