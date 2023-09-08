using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays__8_de_septiembre_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ciudades = { "Osaka", "Tokyo", "Seúl", "Puebla", "Montreal", "Paris", "London", "Buenos Aires" };

            int cantElems = ciudades.Length;
            Console.WriteLine("El arreglo tiene " + cantElems + " elementos");
            
            string ciudad1 = ciudades[1];
            string ciudad4 = ciudades[4];
            Console.WriteLine(ciudad1);
            Console.WriteLine(ciudad4);
            Console.WriteLine(ciudades[0]);
            Console.WriteLine(ciudades[5]);
            ciudades[4] = "Otawa";
            Console.WriteLine(ciudades[4]);

            for(int i = 0; i < 8; i++)
            {//harcodeado el 8 :ccc

            }
            for(int i = 0;i< ciudades.Length; i++)
            {//Parametrizado :D
                Console.WriteLine(i + " - " + ciudades[i]);
            }

            Console.Read();

        }
    }
}
