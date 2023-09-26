using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Circulo
    {
        private double radio;
        
        public Circulo(float valorRadio) //Contructor de ciruclos
        {
            radio = valorRadio;
        }

        public double calcPeri()
        {
           double perimetro = radio * 2 * Math.PI;
           return perimetro;
        }
    }
}
