using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrelgoDeNombres
{
    class GeneradorNombre
    {


        public string[] prefijo = { "Chomp", "Bite", "Titan", "Mega" };
        public string[] subfijo = { "Plodicus", "Donnicus", "Zilla", "Saur" };

        public void Generar(int PrimerNombre, int SegundoNombre)
        {
            Console.WriteLine("Lista de prefijos para tu nombre de dinosaurio");
            Console.WriteLine();

                for(int i=0; i<prefijo.Length ;i++)
                {
                    Console.WriteLine(i + 1 + "-" + prefijo[i]);
                }

            Console.WriteLine();
            Console.WriteLine("Lista de subfijos para tu nombre de dinosaurio");
            Console.WriteLine();

                for (int i = 0; i < subfijo.Length; i++)
                {
                    Console.WriteLine(i + 1 + "-" + subfijo[i]);
                }

            Console.WriteLine();
            Console.WriteLine("Escoge tu prefijo");
            Console.WriteLine();
            PrimerNombre = int.Parse(Console.ReadLine());
            Console.WriteLine("Escoge tu subfijo");
            Console.WriteLine();
            SegundoNombre = int.Parse(Console.ReadLine());

            Console.WriteLine("Tu nombre de dinosaurio es " + prefijo[PrimerNombre-1] + subfijo[SegundoNombre-1]);
            Console.Read();
        }
        

    }
}
