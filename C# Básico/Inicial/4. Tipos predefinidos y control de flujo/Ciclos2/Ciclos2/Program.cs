using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ciclos2
{
    /// <summary>
    /// Ciclos 2
    /// break y continue
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Ciclo For
            Console.WriteLine("Uso de break");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Valor del contador i: {0}", i);
            }

            // Ciclo while
            Console.WriteLine("\nUso de continue");
            int n = 0; // declaración del contador
            while (n < 10)
            {
                Console.WriteLine("Valor del contador n: {0}", n);
                n++; // incremento manual
            }
        }
    }
}
