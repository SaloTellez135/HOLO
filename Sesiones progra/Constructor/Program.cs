using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rect1 = new Rectangulo();
            rect1.describir();
            float area1 = rect1.calcArea();
            Console.WriteLine("Area = " + area1);



            //rectangulo con altura duferente
            Rectangulo rect2 = new Rectangulo();
            rect2.setAlto(12);
            rect1.describir();
            float area2 = rect2.calcArea();
            Console.WriteLine("Area = " + area2);

            

            Rectangulo rect3 = new Rectangulo(3,2);
            rect3.describir();
            float area3 = rect3.calcArea();
            Console.WriteLine("Area = " + area3);

            //circulos

            Circulo cir1 = new Circulo(5);
            double per1 = cir1.calcPeri();
            Console.WriteLine("El perimetro del circulo es " + per1);

            Circulo cir2 = new Circulo(12);
            double per2 = cir2.calcPeri();
            Console.WriteLine("El perimetro del circulo es " + per2);

            //triangulos

            Triangulo tri1 = new Triangulo(3, 5, 6);
            float peri1 = tri1.calcPeri();
            Console.WriteLine("El perimetro del triangulo es " + peri1);

            Triangulo tri2 = new Triangulo(5, 46, 4);
            float peri2 = tri2.calcPeri();
            Console.WriteLine("El perimetro del triangulo es " + peri2);

            //zapatos 

            Zapato zap1 = new Zapato("Negro", 9);
            zap1.descShoe();

            Zapato zap2 = new Zapato("Café", 7);
            zap2.descShoe();

            //personas

            Persona pers1 = new Persona(2001);
            pers1.calcEdad();

            Persona pers2 = new Persona(1993);
            pers2.calcEdad();

            //productos

            Producto prod1 = new Producto(256.5);
            prod1.calIva();

            Producto prod2 = new Producto(167.6);
            prod2.calIva();

            //emails

            Email correo1 = new Email("Carta de renuncia", "Odio trabajar aqui, los odio", "HR");
            correo1.leerMail();

            Email correo2 = new Email("Felicitacion", "Feliz cum, pasatela waos, besos en la cola", "Angel el mamahuevo monrroy");
            correo2.leerMail();

            Console.ReadLine();



        }
    }
}
