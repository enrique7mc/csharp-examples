using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Propiedades
{
    /// <summary>
    /// Propiedades
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta = new CuentaBancaria();
            
            cuenta.Saldo = -5;
            Console.WriteLine("Saldo después de primera asignación: {0}", cuenta.Saldo);

            cuenta.Saldo = 10;
            Console.WriteLine("Saldo después de segunda asignación: {0}", cuenta.Saldo);
        }
    }
}
