using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OtroMetodos
{
    /// <summary>
    /// Otros métodos comunes de LINQ
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturas = { 72.0, 81.5, 69.3, 88.6, 80.0, 68.5 };            
        }

        static void ImprimeEnumerable<T>(IEnumerable<T> datos)
        {
            foreach (var dato in datos)
            {
                Console.Write(" {0}", dato);
            }
            Console.WriteLine();
        }
    }
}
