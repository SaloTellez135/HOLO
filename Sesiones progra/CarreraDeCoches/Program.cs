using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraDeCoches
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto ferrari = new Auto();
            ferrari.modelo = "Ferrari Enzo";
            ferrari.velocidad = 120;

            Auto Mclaren = new Auto();
            Mclaren.modelo = "F1";
            Mclaren.velocidad = 160;

            PistaCarreras Monaco = new PistaCarreras();
            Monaco.nombre = "Monaco";
            Monaco.longitud = 3.33f;

            ferrari.PonerGasolina(10f);
            Mclaren.PonerGasolina(10f);

            ferrari.Arrancar();
            Mclaren.Arrancar();

            ferrari.Acelerar(40);
            Mclaren.Acelerar(40);



            Monaco.Competir(Mclaren, ferrari);
            //Linea para aguardar enter para continuar
            Console.ReadLine();

            ferrari.Frenar();
            Mclaren.Frenar();


        }
    }
}
