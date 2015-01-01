using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetodosDeInstancia
{
    /// <summary>
    /// Métodos de instancia
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta1 = new CuentaBancaria("001", "John Doe", 100);
            CuentaBancaria cuenta2 = new CuentaBancaria("002", "Jane Doe", 250);

            // Llamando los métodos depositar y retirar
            Console.WriteLine("Depositar $70 en cuenta1");
            cuenta1.Depositar(70);
            Console.WriteLine("Retirar $20 en cuenta2");
            cuenta2.Retirar(20);

            // Llamando al método ToString()
            Console.WriteLine(cuenta1.ToString());
            Console.WriteLine(cuenta2);
        }
    }
}
