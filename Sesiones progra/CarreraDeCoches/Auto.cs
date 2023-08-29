using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarreraDeCoches
{
    public class Auto
    {
        public string modelo;
        public Color color;
        public int velocidad;
        public float gasolina;

        public void Arrancar()
        {
            if (gasolina > 0)
            {

                gasolina = gasolina - 0.1f;
                Console.WriteLine("Arrancando " + modelo + " le queda" + gasolina + " L de gasolina");

            }
            else
            {
                Console.WriteLine(modelo + " no tiene gas, no se puede arrancar");
            }

        }
        
        public void PonerGasolina (float Cantidad)
        {
            gasolina = gasolina + Cantidad;
            Console.WriteLine("Se puso gas a " + modelo + " Ahora tiene " + gasolina + "litros");
        }
        public void Acelerar(int cantidad)
        {
            velocidad = velocidad + cantidad;
            Console.WriteLine("El " + modelo + "ha acelerado a " + velocidad + "km/h");

            gasolina = gasolina - (cantidad * 0.1f);

            if (gasolina <= 0)
            {
                Console.WriteLine("Se acabo la gasolina");

            }

        }
        public void Frenar()
        {
            velocidad = 0;
            Console.WriteLine(modelo + " ha frenado");
        }

    }
 }

  



