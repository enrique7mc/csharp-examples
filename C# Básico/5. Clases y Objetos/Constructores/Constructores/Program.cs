using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructores
{
    /// <summary>
    /// Constructores
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Usando el constructor con un argumento
            CuentaBancaria cuenta1 = new CuentaBancaria("000001");
            Console.WriteLine("NoCuenta: {0}, Usuario: {1}, Saldo: {2}", cuenta1.NoCuenta,
                cuenta1.Usuario, cuenta1.Saldo);

            // Usando el constructor con dos argumentos
            CuentaBancaria cuenta2 = new CuentaBancaria("000002", "John Doe");
            Console.WriteLine("NoCuenta: {0}, Usuario: {1}, Saldo: {2}", cuenta2.NoCuenta,
                cuenta2.Usuario, cuenta2.Saldo);

            // Usando el constructor con tres argumentos
            CuentaBancaria cuenta3 = new CuentaBancaria("000003", "Jane Doe", 1000);
            Console.WriteLine("NoCuenta: {0}, Usuario: {1}, Saldo: {2}", cuenta3.NoCuenta,
                cuenta3.Usuario, cuenta3.Saldo);

            // Para usar el constructor por vacío hay que escribirlo en la clase CuentaBancaria
            // Sólo se genera de forma automática si no existe otro constructor en la clase
            CuentaBancaria otra = new CuentaBancaria();
            // mostrar datos de cuenta
        }
    }
}
