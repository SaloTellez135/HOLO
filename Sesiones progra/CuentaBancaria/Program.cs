using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria Cuenta1 = new CuentaBancaria();
            Cuenta1.setPin(1234);
            Cuenta1.getPin();
            Cuenta1.setSaldo(1456.2);
            Cuenta1.getSaldo();


        }
    }
}
