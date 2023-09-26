using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Zapato
    {
        private string color;
        private float talla;

        public Zapato(string colorr, float num)
        {
            color = colorr;
            talla = num;
        }

        public void descShoe()
        {
            Console.WriteLine("El zapaton que ha escogido es de color " + color + " y de talla " + talla);
        }
    }
}
