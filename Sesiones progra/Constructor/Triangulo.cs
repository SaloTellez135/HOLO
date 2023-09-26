using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Triangulo
    {
        private float side1;
        private float side2;
        private float side3;

        public Triangulo(float valor1, float valor2,float valor3)
        {
            side1 = valor1;
            side2 = valor2;
            side3 = valor3;
        }

        public float calcPeri()
        {
            float perimetro = side1 + side2 + side3;
            return perimetro;
        }
    }
}
