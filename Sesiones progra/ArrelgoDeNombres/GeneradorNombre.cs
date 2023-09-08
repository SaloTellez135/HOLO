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

        public void generar(int PrimerNombre, int SegundoNombre)
        {
            Console.WriteLine("Tu nombre de dinosaurio es " + prefijo[PrimerNombre] + subfijo[SegundoNombre]);
        }
        

    }
}
