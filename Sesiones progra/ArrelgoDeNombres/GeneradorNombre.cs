using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrelgoDeNombres
{
    class GeneradorNombre
    {


        public string[] prefijos = { "Chomp", "Bite", "Titan", "Mega","Dilla","Stego","Gigga","Mela","Strepto",};
        public string[] subfijos = { "Plodicus", "Donnicus", "Zilla", "Saur","Wigga","Yaurus", "Meaurus"};

        public void generar(int primerNombre, int segundoNombre)
        {
            Console.WriteLine("Lista de prefijos para tu nombre de dinosaurio");
            Console.WriteLine();

                for(int i=0; i<prefijos.Length ;i++)
                {
                    Console.WriteLine(i + 1 + "-" + prefijos[i]);
                }

            Console.WriteLine();
            Console.WriteLine("Lista de subfijos para tu nombre de dinosaurio");
            Console.WriteLine();

                for (int i = 0; i < subfijos.Length; i++)
                {
                    Console.WriteLine(i + 1 + "-" + subfijos[i]);
                }

            Console.WriteLine();
            Console.WriteLine("Escoge tu prefijo");
            Console.WriteLine();
            primerNombre = int.Parse(Console.ReadLine());
            Console.WriteLine("Escoge tu subfijo");
            Console.WriteLine();
            segundoNombre = int.Parse(Console.ReadLine());

            Console.WriteLine("Tu nombre de dinosaurio es " + prefijos[primerNombre-1] + subfijos[segundoNombre-1]);
            Console.Read();
        }
        

    }
}
