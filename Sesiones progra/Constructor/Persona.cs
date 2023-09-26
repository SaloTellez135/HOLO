using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Persona
    {
        private int yearOB;

        public Persona(int yearOfBirth)
        {
            yearOB = yearOfBirth;
        }

        public int calcEdad()
        {
            int edad = 2023 - yearOB;
            Console.WriteLine("Tu edad es " + edad + " qué ruco");
            return edad;

        }

    }
}
