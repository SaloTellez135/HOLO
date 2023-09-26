using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Email
    {
        private string subject;
        private string contenido;
        private string destinatario;

        public Email(string titulo, string cuerpo, string dest)
        {
            subject = titulo;
            contenido = cuerpo;
            destinatario = dest;
        }

        public void leerMail()
        {
            Console.WriteLine(subject);
            Console.WriteLine();
            Console.WriteLine(contenido);
            Console.WriteLine();
            Console.WriteLine(destinatario);
        }
    }
}
