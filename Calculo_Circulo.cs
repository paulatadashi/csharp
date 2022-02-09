using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaioDiametro
{
    public class circulo
    {
        private double diametro;
        private double raio;
        
        public double Diametro
        {
            set
            {
                if (value > 0)
                {
                    diametro = value;
                    raio = diametro / 2;
                }
                else
                    throw new Exception("Valores negativos não são aceitos");                 
            }
            get { return diametro; }          
        }

        public double Raio
        {
            get { return raio; }
        }
         public double CalcularArea()
         {
             return Math.PI * (raio * raio);
         }

        public double CalcularCircuferencia()
        {
           return 2 * Math.PI * raio;
        }
    }
}
