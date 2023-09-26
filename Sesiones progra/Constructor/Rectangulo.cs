using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Rectangulo
    {
        private float ancho = 5;
        private float alto = 10;

        public Rectangulo() //contructor sin parametros
        {

        }

        public Rectangulo(float valorAncho, float valorAlto) //Constructor que si acepta parametros
        {
            ancho = valorAncho;
            alto = valorAlto;
        }

        public void describir()
        {
            Console.WriteLine("Rectangulo " + ancho + "x" + alto);
        }
        public float calcArea()
        {
            float area = alto * ancho;
            return area;
        }

        public void setAlto(float valor)
        {
            alto = valor;
        }

    }
}
