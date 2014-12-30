using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ciclos
{
    /// <summary>
    /// Ciclos de repetición
    /// For
    /// While
    /// Do While
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Ciclo For
            Console.WriteLine("Usando ciclo for");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Valor del contador i: {0}", i);
            }

            // Ciclo while
            Console.WriteLine("\nUsando ciclo while");
            int n = 0; // declaración del contador
            while (n < 5)
            {
                Console.WriteLine("Valor del contador n: {0}", n);
                n++; // incremento manual
            }

            // Ciclo Do While
            // Este ciclo garantiza ejecutarse al menos una vez
            // a diferencia del ciclo while
            Console.WriteLine("\nUsando ciclo do while");
            int c = 0;
            do
            {
                Console.WriteLine("Valor del contador c: {0}", c);
                c++;
            } while (c < 5);
        }
    }
}
