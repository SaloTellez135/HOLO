using System;
namespace Clases_vol._1__15_Agosto_
{
    class program
    {
        static void Main(string[] args)
        {
            //punto de inicio del programa
            DispositivoMovil miIphone = new DispositivoMovil();
            miIphone.almacenamiento = 64;
            miIphone.ram = 16;
            miIphone.resHeight = 1080;
            miIphone.resWidth = 1920;
            miIphone.color = new Color();
            miIphone.color.rojo = 123;
            miIphone.color.verde = 56;
            miIphone.color.azul = 146;

            DispositivoMovil tabletSamsung = new DispositivoMovil();
            tabletSamsung.almacenamiento = 256;
            tabletSamsung.ram = 32;
            tabletSamsung.resHeight = 1080;
            tabletSamsung.resWidth = 1920;
            tabletSamsung.color = new Color();
            tabletSamsung.color.rojo = 249;
            tabletSamsung.color.verde = 231;
            tabletSamsung.color.azul = 84;



        }

    }
}
