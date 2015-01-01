using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiembrosEstaticos
{
    /// <summary>
    /// Miembros estáticos
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            /* Para acceder a los miembros estáticos se utiliza solo 
             el nombre de la clase */
            CuentaBancaria cuenta1 = new CuentaBancaria("001", "John Doe", 100);
            CuentaBancaria cuenta2 = new CuentaBancaria("002", "Jane Doe", 250);
            // Acceso a miembros estáticos
            CuentaBancaria.Banco = "Mi Banco";
            
            // Mostrar datos de las cuentas
            Console.WriteLine(cuenta1);
            Console.WriteLine(cuenta2);

            Console.WriteLine("Cambiando el banco...");
            CuentaBancaria.AsignarBanco("Otro Banco");

            Console.WriteLine(cuenta1);
            Console.WriteLine(cuenta2);
        }
    }
}
