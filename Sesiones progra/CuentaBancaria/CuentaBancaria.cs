using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria
{
    class CuentaBancaria
    {
        private int pin;
        private double saldo;

        
        public void setPin(int valor)
        {
            pin = valor;
        }
        public int getPin()
        {
            return pin;
        }

        public void setSaldo(double valor)
        {
            saldo = valor;
        }
        public double getSaldo()
        {
            if(pin != 0)
            {
                return saldo;
                Console.WriteLine("Su saldo es " + saldo);
                Console.Read();
            }
            
            else
            {
                Console.WriteLine("No se ha establecido un pin, establezcalo para conocer su saldo");
                return 0;
            }
        }


    }
}
