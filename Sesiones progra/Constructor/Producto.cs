using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Producto 
    {
        private double precio;

        public Producto(double costo)
        {
            precio = costo;
        }

        public double calIva()
        {
            double precioIVA = precio + (precio * .16);
            Console.WriteLine("El precio màs el IVA es " + precioIVA);
            return precioIVA;
        }
    }
}
